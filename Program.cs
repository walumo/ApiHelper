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

            

            Console.WriteLine("Loading...");

            Fruit x = await client.GetDataAsync<Fruit>("banana");

            Console.Clear();
            Console.WriteLine(x.name);


        }
    }
}
