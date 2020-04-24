using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVirtual.Services.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            //TODO - Entities to ViewModel

            //CreateMap<Entitie, ViewModel>()
            //    .ForMember(dest => dest.propiedadeDestino, opt => opt.MapFrom(src => src.Entitie));
        }
    }
}
