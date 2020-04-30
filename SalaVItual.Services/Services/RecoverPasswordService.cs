using AutoMapper.Configuration;
using SalaVirtual.Util;
using System;
using System.Collections.Generic;
using System.Text;


namespace SalaVItual.Services.Services
{
    public class RecoverPasswordService : IRecoverPasswordService
    {

        public RecoverPasswordService()
        {
            
        }

        public bool Recover(string email)
        {

            //string recoveryPassword = repositoryRecoveryPassword.recover(email);

            SendEmail sendEmail = new SendEmail();

            //TODO - senha = recoveryPassword
            sendEmail.Email(email, "9826test" /*recoveryPassword*/);

            return true/*recoveryResult*/;
        }

    }
}
