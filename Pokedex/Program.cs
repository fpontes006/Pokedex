
using System.Text.Json;
using RestSharp;
using System;


namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonGet();
        }

        public static void PokemonGet()
        {
            Console.Write("Entre com o Nome do Pokemon: ");
            var especie = Console.ReadLine();

            var url = new RestClient($"https://pokeapi.co/api/v2/pokemon/{especie.ToLower()}");
            var request = new RestRequest("", Method.Get);
            var response = url.Execute(request);

            
              var listPokemon =   JsonSerializer.Deserialize<Pokemon>(response.Content);

            Console.WriteLine($"Nome Pokemon: {listPokemon.name}");
            Console.WriteLine($"Altura: {listPokemon.height}");
            Console.WriteLine($"Peso: {listPokemon.weight}");
            Console.WriteLine("Habilidades: ");
            foreach (var pok in listPokemon.abilities)
            {
                Console.WriteLine(pok.ability.name.ToUpper() + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}



