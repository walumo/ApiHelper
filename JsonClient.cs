using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiHelper
{
    public class JsonClient
    {
        const string baseUrl = "https://fruityvice.com/api/fruit/"; //Set to your endpoint url
        public async Task<T> GetDataAsync<T>(string urlParams) //urlParams are your query parameters
        {
            string url = baseUrl + urlParams;

            using (HttpResponseMessage response = await API.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string msg = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<T>(msg);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        public static void Print<T>(T json)
        {
            //Implement printing from Json in object:'data'
        }
    }
}
