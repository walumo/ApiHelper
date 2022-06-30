using System;
using System.Collections.Generic;
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

            List<Fruit> fruitList = await client.GetAllDataAsync<Fruit>("all"); //get all from fruityvice API

            Fruit oneFruit = await client.GetDataAsync<Fruit>("banana"); //query single fruit by name

            try
            {
                foreach (Fruit fruit in fruitList)
                {
                    Console.WriteLine(fruit.name);
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\nName of the single fruit: {0}", oneFruit.name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
