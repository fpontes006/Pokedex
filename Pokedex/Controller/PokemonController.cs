using AutoMapper;
using Pokedex.Model;
using Pokedex.Service;
using Pokedex.View;

namespace Pokedex.Controller
{
    public class PokemonController
    {
        private string NomeJogador { get; set; }
        private List<Mascote> MascoteAdotados { get; set; }
        private PokemonView Mensagens { get; set; }

        private MascoteMapping Mapeador;

        public PokemonController()
        {
            this.MascoteAdotados = new List<Mascote>();
            this.Mensagens = new PokemonView();
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
            string opcaoUsuario = "1", especieMascote;
            Pokemon pokemon = new();
            Mascote mascote = new();

            especieMascote = Mensagens.MenuAdocao();

            while (opcaoUsuario != "3")
            {
                opcaoUsuario = Mensagens.DesejaSaberMais(especieMascote);

                switch (opcaoUsuario)
                {
                    case "1":
                        pokemon = PokemonService.GetPokemon(especieMascote);

                        Mapper.CreateMap<Pokemon, Mascote>()
                            .ForMember(dest => dest.Altura, opt => opt.MapFrom(src => src.height))
                            .ForMember(dest => dest.Peso, opt => opt.MapFrom(src => src.weight))
                            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.name))
                            .ForMember(dest => dest.Habilidades, opt => opt.MapFrom(src => src.abilities));
                        mascote = Mapper.Map<Pokemon, Mascote>(pokemon);
                        Mensagens.DetalhesMascote(pokemon);
                        break;

                    case "2":
                        pokemon = PokemonService.GetPokemon(especieMascote);

                        Mapper.CreateMap<Pokemon, Mascote>()
                            .ForMember(dest => dest.Altura, opt => opt.MapFrom(src => src.height))
                            .ForMember(dest => dest.Peso, opt => opt.MapFrom(src => src.weight))
                            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.name))
                            .ForMember(dest => dest.Habilidades, opt => opt.MapFrom(src => src.abilities));

                        mascote = Mapper.Map<Pokemon, Mascote>(pokemon);

                        this.MascoteAdotados.Add(mascote);
                        Mensagens.SucessoAdocao(NomeJogador);
                        return;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Opcao Invalida! Tente Novamente: ");
                        break;
                }
            }
        }

        public void MenuInteracao()
        {
            string opcaoUsuario = "0";
            int indiceMascote;

            indiceMascote = Mensagens.MenuConsultarMascotes(MascoteAdotados);
            while (opcaoUsuario != "4")
            {
                opcaoUsuario = Mensagens.InteragirComMascotes(MascoteAdotados[indiceMascote]);

                switch (opcaoUsuario)
                {
                    case "1":
                        Mensagens.DetalhesMascoteAdotado(MascoteAdotados[indiceMascote]);
                        break;

                    case "2":
                        MascoteAdotados[indiceMascote].AlimentarMascote();
                        Mensagens.AlimentarMascoste();
                        if (!MascoteAdotados[indiceMascote].SaudeMascote())
                            Mensagens.GameOver(MascoteAdotados[indiceMascote]);
                        break;

                    case "3":
                        MascoteAdotados[indiceMascote].BrincarMascote();
                        if (!MascoteAdotados[indiceMascote].SaudeMascote())
                        {
                            Mensagens.GameOver(MascoteAdotados[indiceMascote]);
                        }
                        break;

                    default:
                        Console.WriteLine("Opcção Invalida");
                        break;
                }
            }
        }
    }
}