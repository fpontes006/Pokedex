using Pokedex.Model;
using RestSharp;
using System.Text.Json;

namespace Pokedex.Service
{
    public class PokemonService
    {
        public static Pokemon GetPokemon(string especie)
        {
            var url = new RestClient($"https://pokeapi.co/api/v2/pokemon/{especie.ToLower()}");
            var request = new RestRequest("", Method.Get);
            var response = url.Execute(request);

            return JsonSerializer.Deserialize<Pokemon>(response.Content);
        }
    }
}