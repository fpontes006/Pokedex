using Pokedex.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.View
{
    public class PokemonView
    {
        private string NomeJogador { get; set; }

        public PokemonView()
        {
            BoaVindas();
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
        public void DetalheMascote(Mascote mascote)
        {
            Console.WriteLine("\n______________________________________________________________________");
            Console.WriteLine($"Nome Mascote: {mascote.Nome.ToUpper()}");
            Console.WriteLine($"Altura Mascote: {mascote.Altura}");
            Console.WriteLine($"Peso Mascote: {mascote.Peso}");

            Console.WriteLine("Habilidades: ");
            foreach (var hab in mascote.Habilidades)
            {
                Console.Write(hab.ability.name.ToUpper() + " ");
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
    }
}
