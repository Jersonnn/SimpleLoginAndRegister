using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SimpleLoginAndRegister
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.Show();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "username", txtUsername.Text },
                    { "password", txtPassword.Text }
                };

                var content = new FormUrlEncodedContent(values);

                //api php link mo lagay 
                var response = await client.PostAsync("https://localhost/api/login.php", content);

                var responseString = await response.Content.ReadAsStringAsync();
                txtResponse.Text = responseString;
                Console.WriteLine($"Response: {responseString}");

                try
                {
                    var responseJson = JObject.Parse(responseString);

                    if (responseJson["message"].ToString() == "Login successful")
                    {
                        MessageBox.Show("Login successful!");
                        // Dashboard form mo lagay mo rito
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
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