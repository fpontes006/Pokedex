using Pokedex.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Pokedex.View
{
    public class PokemonView
    {
        private string NomeJogador { get; set; }

        public PokemonView()
        {
            BoaVindas();
            Console.WriteLine(@"Ⓟⓞⓚⓔⓜⓞⓝ");
        }

        public void BoaVindas()
        {
            Console.WriteLine("\n\nQual o Seu Nome? ");
            NomeJogador =  Console.ReadLine().ToUpper();
        }

        public void MenuInicial()
        {
            Console.WriteLine("\n\n_________________________________ MENU _____________________________");
            Console.WriteLine($"{NomeJogador} Você Deseja:");
            Console.WriteLine("1 - Adotar um moscote virtual");
            Console.WriteLine("2 - Ver seus macostes");
            Console.WriteLine("3 - Sair");
        }

        public string MenuAdocao()
        {
            Console.WriteLine("\n\n_____________________ ADOTAR UM MASCOTE ____________________________");
            Console.WriteLine($"{NomeJogador} Escolha uma especia: ");
            Console.WriteLine("BULBASAUR");
            Console.WriteLine("IVYSAUR");

            return Console.ReadLine().ToUpper();
        }

        public string DesejaSaberMais(string especie)
        {
            Console.WriteLine("\n______________________________________________________________________");
            Console.WriteLine($"{NomeJogador} VOCÊ DESEJA:");
            Console.WriteLine($"1 - SABER MAIS SOBRE O {especie}");
            Console.WriteLine($"2 - ADOTAR O {especie}");
            Console.WriteLine($"3 - VOLTAR");

            return Console.ReadLine().ToUpper();
        }

        public void DetalhesMascote(Pokemon pokemon)
        {
            Console.WriteLine("\n______________________________________________________________________");
            Console.WriteLine($"Nome Pokemon: {pokemon.name.ToUpper()}");
            Console.WriteLine($"Altura: {pokemon.height}");
            Console.WriteLine($"Peso: {pokemon.weight}");

            Console.WriteLine("Habilidades: ");
            foreach (var hab in pokemon.abilities)
            {
                Console.Write(hab.ability!.name!.ToUpper() + " ");
            }
        }
        public void DetalhesMascoteAdotado(Pokemon pokemon)
        {
            Console.WriteLine("\n______________________________________________________________________");
            Console.WriteLine($"Nome Mascote: {pokemon.name.ToUpper()}");
            Console.WriteLine($"Altura Mascote: {pokemon.height}");
            Console.WriteLine($"Peso Mascote: {pokemon.weight}");

            TimeSpan idade = DateTime.Now.Subtract(pokemon.DataNascimento);

            Console.WriteLine($"Idade: {idade.Minutes} Anos em Pokemon Virtual");

            if (true)
            {

            }
        }
        public void SucessoAdocao(string especie)
        {
            Console.WriteLine($"{NomeJogador} MASCOTE ADOTADO COM SUCESSO,O OVO ESTÉ CHOCANDO");
            Console.WriteLine(@"
              ███╗
             ██████╗
            ████████╗
            ████████║
            ████████║
            ╚█████╔╝
             ╚════╝");
        }

        public int MenuConsultarMascotes(List<Pokemon> pokemons)
        {
            Console.WriteLine("\n__________________________________________________________________________");
            Console.WriteLine($"Voce Possui {pokemons.Count} Pokemon Adotados.");
            for (int indicePokemon = 0; indicePokemon < pokemons.Count; indicePokemon++)
            {
                Console.WriteLine($"{indicePokemon} - {pokemons[indicePokemon].name.ToUpper()}");
            }

            Console.WriteLine($"Qual Pokemon você deseja interagir? ");
            return Convert.ToInt32( Console.ReadLine() );
        }

        public string InteragirComMascotes(Pokemon pokemon)
        {
            Console.WriteLine("\n___________________________________________________________________________");
            Console.WriteLine($"{NomeJogador} VOCE DESEJA:");
            Console.WriteLine($"1 - SABER COMO O {pokemon.name.ToUpper()}");
            Console.WriteLine($"2 - ALIMENTAR O  {pokemon.name.ToUpper()}");
            Console.WriteLine($"3 - BRINCAR COM O {pokemon.name.ToUpper()}");
            Console.WriteLine($"4 - VOLTAR");

            return Console.ReadLine().ToUpper();
        }

        public void AlimentarMascoste()
        {
            Console.WriteLine("\n_____________________________________________________________________________");
            Console.WriteLine($"(=^w^=)");
            Console.WriteLine($"Pokemon Alimentado");
        }

        public void BrincarMascote()
        {
            Console.WriteLine("\n_______________________________________________________________________________");
            Console.WriteLine($"(=^w^=)");
            Console.WriteLine($"Pokemon esta feliz");
        }
        public void GameOver(Pokemon pokemon)
        {
            Console.WriteLine("\n_________________________________________________________________________________");
            Console.WriteLine("O Mascote Morreu de " + (pokemon.Humor > 0 ? "fome" : "Tristeza"));

            Console.WriteLine(@"
              #####      #     #     #  #######      #######  #     #  #######  ######  
             #     #    # #    ##   ##  #            #     #  #     #  #        #     # 
             #         #   #   # # # #  #            #     #  #     #  #        #     # 
             #  ####  #     #  #  #  #  #####        #     #  #     #  #####    ######  
             #     #  #######  #     #  #            #     #   #   #   #        #   #   
             #     #  #     #  #     #  #            #     #    # #    #        #    #  
              #####   #     #  #     #  #######      #######     #     #######  #     # ");
        }
    }
}
