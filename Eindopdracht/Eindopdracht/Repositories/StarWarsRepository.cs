using Eindopdracht.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Repositories
{
    public class StarWarsRepository
    {
        public const string _BASEURL = "https://swapi.dev/api/";

        public static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public static async Task<List<StarWarsPeople>> GetPeoplesAsync()
        {
            string url = $"{_BASEURL}people";

            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    JObject jsonObj = JsonConvert.DeserializeObject<JObject>(json);

                    JToken jsonToken = jsonObj.SelectToken("results");


                    return jsonToken.ToObject<List<StarWarsPeople>>();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
