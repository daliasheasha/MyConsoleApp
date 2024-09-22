XPLANATION START]In order to migrate this app from .NET 6 to .NET 8, you need to make the following changes:

1. Change the namespace declaration to use the new version of .NET: using System.Net.Http;
2. Replace the usage of the HttpWebRequest and HttpWebResponse classes with the HttpClient class, which is recommended in .NET 8.
3. Update the code inside the using statement to read the response content using the asynchronous ReadAsStringAsync() method instead of the ReadToEnd() method.

Here is the corrected file: 
[EXPLANATION END]

[CORRECTED FILE START]
using System;
using System.Net.Http;

namespace WebRequestSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

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
}
