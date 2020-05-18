using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SalaVirtual.Repositories;
using SalaVirtual.Repositories.DataAccess;
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
            serviceCollection.AddTransient<ICreateClassService, CreateClassService>();
            serviceCollection.AddTransient<ISingInClassService, SingInClassService>();
            serviceCollection.AddTransient<IPresencaService, PresencaService>();
        }

        private static void RegisterRepositories(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient <IDbOracleConnection, DbOracleConnection>();
            serviceCollection.AddTransient <IRecoverPasswordRepository, RecoverPasswordRepository>();
            serviceCollection.AddTransient <IRegisterRepository, RegisterRepository>();
            serviceCollection.AddTransient <ICreateClassRepository, CreateClassRepository>();
            serviceCollection.AddTransient <ISingInClassRepository, SingInClassRepository>();
            serviceCollection.AddTransient <IPresencaRepository, PresencaRepository>();
        }

    }
}
