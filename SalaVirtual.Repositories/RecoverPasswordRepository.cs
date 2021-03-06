﻿using Dapper;
using Microsoft.Extensions.Options;
using SalaVirtual.Repositories.DataAccess;
using SalaVirtual.Util.Environment;
using System;
using System.Collections.Generic;

namespace SalaVirtual.Repositories
{


    public class RecoverPasswordRepository : IRecoverPasswordRepository
    {
        private readonly Connection _connection;
        private readonly IDbOracleConnection _dbOracleConnection;


        public RecoverPasswordRepository(IDbOracleConnection dbOracleConnection, IOptions<Connection> connection)
        {
            _dbOracleConnection = dbOracleConnection;
            _connection = connection.Value;
        }

        public IList<int> EmailExist(string email)
        {
            try
            {
                IList<int> conferencia = _dbOracleConnection.Dbconnection().Query<int>("select * from tb_usuario where email_usuario = '" + email + "'").AsList();

                return conferencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string RecoverPassword(string email)
        {
            try
            {
                IList<int> test = _dbOracleConnection.Dbconnection().Query<int>("SELECT fn_recupera_senha ('" + email + "') FROM dual").AsList();

                string password = test[0].ToString();

                return password;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}
