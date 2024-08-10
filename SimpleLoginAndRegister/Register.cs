using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SimpleLoginAndRegister
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "username", txtUsername.Text },
                    { "password", txtPassword.Text }
                };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync("https://localhost/api/register.php", content);

                var responseString = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Response: {responseString}");

                try
                {
                    var responseJson = JObject.Parse(responseString);

                    if (responseJson["message"].ToString() == "Registration successful")
                    {
                        MessageBox.Show("Registration successful!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                    }
                }
                catch (Newtonsoft.Json.JsonReaderException ex)
                {
                    MessageBox.Show($"Error parsing JSON response: {ex.Message}\n\nResponse: {responseString}");
                }
            }
        }
    }
}