
using System;
using System.Net.Http;

namespace WebRequestSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseText = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Response received:");
                Console.WriteLine(responseText);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
    }
}
