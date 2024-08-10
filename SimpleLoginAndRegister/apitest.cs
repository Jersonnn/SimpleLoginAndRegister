using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleLoginAndRegister
{
    class apitest
    {
        private readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            var apiUrl = "https://localhost/Login.php";

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"API is working. Status Code: {response.StatusCode}");
                    }
                    else
                    {
                        Console.WriteLine($"API request failed. Status Code: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occurred while making API request: {ex.Message}");
                }
            }
        }
    }
}