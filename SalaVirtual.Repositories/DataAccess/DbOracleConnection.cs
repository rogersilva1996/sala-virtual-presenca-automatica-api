using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;
using SalaVirtual.Util.Environment;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVirtual.Repositories.DataAccess
{
    public class DbOracleConnection : IDbOracleConnection
    {
        private readonly Connection _connection;
      
        
        public DbOracleConnection(IOptions<Connection> connection)
        {
            _connection = connection.Value;
        }

        public OracleConnection Dbconnection()
        {
            OracleConnection conn = new OracleConnection(_connection.connectionString);

            conn.Open();

            return conn;
        }
    }
}
