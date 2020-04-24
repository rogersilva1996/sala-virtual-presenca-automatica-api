using AutoMapper;

namespace SalaVirtual.Services.AutoMapper
{
    public class AutoMapperConfig
    {
        public void RegisterMappings()
        {

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}