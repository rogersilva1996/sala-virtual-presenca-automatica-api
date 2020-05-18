using SalaVirtual.Repositories;
using SalaVItual.Services.ViewModels;
using System;
using System.Collections.Generic;

namespace SalaVItual.Services.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        private bool result;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public bool login(UserViewModel user)
        {
            try
            {
                IList<int> consulta = _loginRepository.Login(user.email, user.senha);

                result = (consulta[0] == 0) ? true : false;

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
