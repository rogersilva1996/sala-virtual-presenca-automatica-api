using Dapper;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;
using SalaVirtual.Util.Environment;
using System;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using SalaVirtual.Repositories.Entities;

namespace SalaVirtual.Repositories
{


    public class RecoverPasswordRepository : IRecoverPasswordRepository
    {
        private readonly Connection _connection;
        

        public RecoverPasswordRepository(IOptions<Connection> connection)
        {
            _connection = connection.Value;
        }

        public string RecoverPassword(string email)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(_connection.connectionString))
                {
                    conn.Open();

                    IList<int> test = conn.Query<int>("SELECT fn_recupera_senha ('" + email + "') FROM dual").AsList();


                    string password = test[0].ToString();

                    return password;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}
