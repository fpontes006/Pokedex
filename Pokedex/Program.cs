using Newtonsoft.Json;
using RestSharp;
using System;


namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            InvocarGet();
        }

        static void InvocarGet()
        {
            //Console.Write("DIgite abeiro o nome do pokemon que deseja ver: ");
            //var nome = Console.ReadLine();

            var url = $"https://pokeapi.co/api/v2/pokemon/";

            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;

                var listPokemon = JsonConvert.DeserializeObject<Pokemon>(results);

                foreach (var pok in listPokemon.Results)
                {
                    Console.WriteLine(pok.Name);
                }
            }
            Console.ReadKey();
        }
    }

    

    public class Pokemon
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public Result[] Results { get; set; }
    }
    public partial class Result
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}

