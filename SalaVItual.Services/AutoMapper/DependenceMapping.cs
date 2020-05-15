using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SalaVirtual.Repositories;
using SalaVirtual.Util;
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
            serviceCollection.AddTransient<ISendEmail, SendEmail>();
            //serviceCollection.AddTransient<IMapperService, MapperService>();
            serviceCollection.AddTransient <ILoginService, LoginService>();
            serviceCollection.AddTransient <IRegisterService, RegisterService>();
            serviceCollection.AddTransient<IRecoverPasswordService, RecoverPasswordService>();
        }

        private static void RegisterRepositories(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient <IConnectionSample, ConnectionSample>();
        }

    }
}
