[EXPLANATION START] This is the changes needed to be made in order to migrate the app from .NET 6 to .NET 8:
- Change `HttpWebRequest` to `HttpClient` for making the HTTP request.
- Replace `StreamReader` with `HttpContent.ReadAsStringAsync()` to read the response.

The corrected file is as follows:
[EXPLANATION END] [CORRECTED FILE START]
using System;
using System.Net.Http;

namespace WebRequestSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            using HttpClient client = new HttpClient();
            using HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseText = await response.Content.ReadAsStringAsync();
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
[CORRECTED FILE END]