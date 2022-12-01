using Pokedex.Controller;

namespace Pokedex
{
    public class Program
    {
        private static void Main(string[] args)
        {
            PokemonController Jogo = new PokemonController();
            Jogo.Jogar();
        }
    }
}