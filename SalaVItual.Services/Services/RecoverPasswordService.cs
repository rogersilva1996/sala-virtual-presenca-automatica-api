using AutoMapper.Configuration;
using Microsoft.Extensions.Options;
using SalaVirtual.Repositories;
using SalaVirtual.Util;
using SalaVirtual.Util.Environment;
using System;
using System.Collections.Generic;
using System.Text;



namespace SalaVItual.Services.Services
{
    public class RecoverPasswordService : IRecoverPasswordService
    {
        private ISendEmail _sendEmail;
        private IRecoverPasswordRepository _recoverPasswordRepository;

        public RecoverPasswordService(ISendEmail sendEmail, IRecoverPasswordRepository recoverPasswordRepository)
        {
            _sendEmail = sendEmail;
            _recoverPasswordRepository = recoverPasswordRepository;

        }

        public bool Recover(string email)
        {
            try
            {
                IList<int> listEmail = _recoverPasswordRepository.EmailExist(email);

                if(listEmail.Count > 0)
                {
                    string password = _recoverPasswordRepository.RecoverPassword(email);

                    _sendEmail.Email(email, password);
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
