using Dapper;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;
using SalaVirtual.Util.Environment;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVirtual.Repositories
{
    public class LoginRepository
    {
        private readonly Connection _connection;

        public LoginRepository(IOptions<Connection> connection)
        {
            _connection = connection.Value;
        }

        //public bool Login(string email, string senha)
        //{
        //    try
        //    {
        //        using (OracleConnection conn = new OracleConnection(_connection.connectionString))
        //        {
        //            conn.Open();

        //            IList<int> retorno = conn.Query<int>("SELECT fn_verifica_login ('" + email + "'"+ ",'" + senha + "') FROM dual").AsList();

        //           if(retorno[0] == 1)
        //            {

        //            }
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

    }
}
