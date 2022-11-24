using Pokedex.Model;
using Pokedex.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Controller
{
    public class PokemonController
    {
        private string NomeJogador { get; set; }
        private List<Mascote> MascoteAdotados { get; set; }
        private PokemonView Mensagens { get; set; }

        // private MascoteMapping Mapeador;

        public PokemonController()
        {
            this.MascoteAdotados= new List<Mascote>();
            this.Mensagens= new PokemonView();
        }
        public void Jogar()
        {
            string opcaoUsuario;
            int jogar = 1;

            while (jogar == 1)
            {
                Mensagens.MenuInicial();
                opcaoUsuario = Console.ReadLine();

                switch (opcaoUsuario)
                {
                    case "1": MenuAdocao(); break;
                    case "2": MenuInteracao(); break;
                    case "3": jogar = 0; break;
                    default:
                        Console.WriteLine("Opcao Inválida! Tente Novamente. ");
                        break;
                }
            }
        }

        public void MenuAdocao() 
        {
            
        }
        public void MenuInteracao()
        {

        }

    }
}
