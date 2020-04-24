using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVirtual.Services
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //TODO - ViewModel to entities

            //CreateMap<Entitie, ViewModel>()
            //    .ForMember(dest => dest.propiedadeDestino, opt => opt.MapFrom(src => src.Entitie));
        }
    }
}
