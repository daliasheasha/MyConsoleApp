[CORRECTED FILE START]using System.Net;

namespace WebRequestSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
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
}[CORRECTED FILE END]using System.Net;

namespace WebRequestSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
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