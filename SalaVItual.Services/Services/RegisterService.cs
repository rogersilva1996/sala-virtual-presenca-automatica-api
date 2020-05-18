using SalaVirtual.Repositories;
using SalaVItual.Services.ViewModels;
using System;
using System.Collections.Generic;

namespace SalaVItual.Services.Services
{

    public class RegisterService : IRegisterService
    {
        private readonly IRegisterRepository _registerRepository;
        private bool result;

        public RegisterService(IRegisterRepository registerRepository)
        {
            _registerRepository = registerRepository;
        }

        public bool Register(UserViewModel user)
        {
            try
            {
                IList<int> validateCreate = _registerRepository.ValidateCreateAcout(user.email);

                result = (validateCreate.Count == 0) ? true : false;

                if (result)
                {
                    _registerRepository.CreateAcout(user.nome, user.email, user.senha);

                    return true;
                }

                return false;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
