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
        private IRecoverPasswordRepository _connectionSample;

        public RecoverPasswordService(ISendEmail sendEmail, IRecoverPasswordRepository connectionSample)
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
                string password = _connectionSample.RecoverPassword(email);

                _sendEmail.Email(email, password);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }



          
        }



    }
}
