using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SalaVItual.Services.Services;

namespace SalaVItual.Services.AutoMapper
{
    public class DependenceMapping
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            RegisterServices(serviceCollection);
            RegisterRepositories(serviceCollection);
        }


        //TODO Injeção de dependencia e instancia de objetos 
        private static void RegisterServices(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddTransient<IMapperService, MapperService>();
            serviceCollection.AddTransient <IServiceTest, ServiceTest>();
        }

        private static void RegisterRepositories(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddTransient<interface, repositories>();
        }

    }
}
