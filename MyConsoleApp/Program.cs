The provided file appears to be written in C# and targets the .NET framework. To migrate this app from .NET 6 to .NET 8, you can make the following changes:

1. Update the target framework in the project file (e.g., `.csproj`) to `<TargetFramework>net8.0</TargetFramework>`.

2. Replace the `HttpWebRequest` and `HttpWebResponse` classes with the `HttpClient` class, which provides a more modern and efficient way to make HTTP requests.

Here's the updated code with the necessary changes:

```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebRequestSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            using HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

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
```

Please note that the updated code uses the `async/await` pattern to perform asynchronous operations with the `HttpClient`. Make sure to handle any necessary error handling and exception scenarios according to your specific requirements.

Let me know if you need any further assistance!