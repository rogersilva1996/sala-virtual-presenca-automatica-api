using AutoMapper.Configuration;
using SalaVirtual.Util;
using System;
using System.Collections.Generic;
using System.Text;


namespace SalaVItual.Services.Services
{
    public class RecoverPasswordService : IRecoverPasswordService
    {
        private ISendEmail _sendEmail;

        public RecoverPasswordService(ISendEmail sendEmail)
        {
            _sendEmail = sendEmail;
        }

        public bool Recover(string email)
        {
            try
            {
                //string recoveryPassword = repositoryRecoveryPassword.recover(email);

                //TODO - senha = recoveryPassword
                _sendEmail.Email(email, "9826test" /*recoveryPassword*/);

                return true/*recoveryResult*/;
            }
            catch
            {
                return false;
            }

            //string recoveryPassword = repositoryRecoveryPassword.recover(email);

            //TODO - senha = recoveryPassword
            _sendEmail.Email(email, "9826test" /*recoveryPassword*/);

            return true/*recoveryResult*/;
        }

    }
}
