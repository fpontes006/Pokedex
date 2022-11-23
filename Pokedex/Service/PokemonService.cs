using Pokedex.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
