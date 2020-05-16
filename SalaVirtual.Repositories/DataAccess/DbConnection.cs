using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;
using SalaVirtual.Util.Environment;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVirtual.Repositories.DataAccess
{
    public class DbConnection
    {
        private readonly Connection _connection;
        private readonly IOptions<Connection> connection;

        public DbConnection()
        {
            _connection = connection.Value;
        }

        public OracleConnection Connection()
        {
            try
            {
              


                using (OracleConnection conn = new OracleConnection(_connection.connectionString))
                {
                    conn.Open();

                    return conn;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
