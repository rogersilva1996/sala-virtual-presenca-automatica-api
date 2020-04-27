using SalaVItual.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVItual.Services.Services
{
    public class LoginService : ILoginService
    {

        public LoginService()
        {

        }

        public bool login(UserViewModel user)
        {
            //int cod_erro = repositoryLogin(user.email, user.senha);

            //if (repoistory.login == true)
            //{
            //    return true;
            //}

            return true;
        }
    }
}
