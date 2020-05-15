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
        private IConnectionSample _connectionSample;

        public RecoverPasswordService(ISendEmail sendEmail, IConnectionSample connectionSample)
        {
            _sendEmail = sendEmail;
            _connectionSample = connectionSample;

        }

        public bool Recover(string email)
        {
            try
            {
                //string recoveryPassword = repositoryRecoveryPassword.recover(email);

                //TODO - senha = recoveryPassword
                _connectionSample.teste();
                //_sendEmail.Email(email, "9826test" /*recoveryPassword*/);

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
