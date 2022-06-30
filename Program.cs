using System;
using System.Threading.Tasks;

namespace ApiHelper
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            API.InitializeClient();

            ApiLoader client = new ApiLoader();

            Console.WriteLine("Loading...");

            Fruit x = await client.GetDataAsync<Fruit>("banana");

            Console.WriteLine(x.name);


        }
    }
}
