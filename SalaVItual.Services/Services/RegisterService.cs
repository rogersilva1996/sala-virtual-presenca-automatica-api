using SalaVItual.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVItual.Services.Services
{
    
    public class RegisterService : IRegisterService
    {
        public RegisterService()
        {
            //TODO - dependencia Repository
        }

        public bool Register(UserViewModel user)
        {
            //bool registerRepository = RegisterRepository.Register(user.nome, user.email, user.senha);

            //if (registerRepository == true)
            //{
            //    return true;
            //}
            return true;
        }
    }
}
