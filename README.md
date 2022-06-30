# ApiHelper

Initialize the HttpClient and JsonClient
Use GetDataAsync() to query your API.

```
using System;
using System.Threading.Tasks;

namespace ApiHelper
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            API.InitializeClient();

            JsonClient client = new JsonClient();

            YOUR_CLASS someName = await client.GetDataAsync<YOUR_CLASS>("banana");

            Console.WriteLine(someName.name);

        }
    }
}

```
