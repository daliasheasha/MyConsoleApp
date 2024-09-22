using System.Net;

namespace WebRequestSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the URL to send a request to
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            // Create the WebRequest instance
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            // Optional: Set some request properties
            request.Method = "GET";
            request.ContentType = "application/json";

            // Get the response from the server
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // Check if the status code is OK (200)
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Read the response stream
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string responseText = reader.ReadToEnd();
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
