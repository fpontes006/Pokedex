using AutoMapper;

namespace Pokedex.Model
{
    public class MascoteMapping
    {
        public MascoteMapping()
        {
            Mapper.CreateMap<Pokemon, Mascote>()
                .ForMember(dest => dest.Altura, opt => opt.MapFrom(src => src.height))
                .ForMember(dest => dest.Peso, opt => opt.MapFrom(src => src.weight))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Habilidades, opt => opt.MapFrom(src => src.abilities));
        }
    }
}