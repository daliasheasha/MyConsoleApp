Since you have requested to migrate this app to .NET 8, I assume there are some changes required for this migration. Below is the updated code for the given file:

```csharp
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace WebRequestSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string responseText = await reader.ReadToEndAsync();
                        Console.WriteLine("Response received:");
                        Console.WriteLine(responseText);
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
        }
    }
}
```

Please replace the existing code with the updated code provided above.