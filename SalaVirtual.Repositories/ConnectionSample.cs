using Dapper;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;
using SalaVirtual.Util.Environment;
using System;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace SalaVirtual.Repositories
{


    public class ConnectionSample : IConnectionSample
    {
        private readonly Connection _connection;
        private static readonly string connectinString = "Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.15.25)(PORT = 1521)))(CONNECT_DATA = (SID = xe)));Persist Security Info=True;User ID=SYSTEM;Password=123456789;Pooling=True;Connection Timeout=60;";

        public ConnectionSample(IOptions<Connection> connection)
        {
            _connection = connection.Value;
        }

        public void teste()
        {
            try
            {
                using (var conn = new OracleConnection(connectinString))
                {
                    conn.Open();

                    //OracleCommand com = new OracleCommand("fn_recupera_senha", conn);
                    //OracleParameter paramiter1 = new OracleParameter();
                    //com.Parameters.Add("@pEmail", "roger851996@hotmail.com");

                    //com.CommandType = System.Data.CommandType.StoredProcedure;
                    //com.ExecuteReader();


                 
                    DynamicParameters parameters = new DynamicParameters();
                    //parameter.Add("@pEmail", InvoiceKind.WebInvoice, DbType.Int32, ParameterDirection.Input);
                    //parameters.Add("pEmail", "roger851996@hotmail.com", DbType.String);
                    //cmd.CommandText = "select from fn_recupera_senha('roger851996@hotmail.com')";


                    //var cmd = conn.CreateCommand();
                    //cmd.CommandText = "SELECT fn_recupera_senha ('roger851996@hotmail.com') FROM dual";
                    //var reader = cmd.ExecuteReader();



                    var test = conn.Query<int>("SELECT fn_recupera_senha ('roger851996@hotmail.com') FROM dual").AsList();

                    int senha = test[0];
                    ////conn.Execute("@fn_recupera_senha", parameters, commandType: CommandType.StoredProcedure);


                }
            }
            catch (Exception ex)
            {

            }


            //OracleConnection con = new OracleConnection();

            ////using connection string attributes to connect to Oracle Database
            //con.ConnectionString = "User Id=SYSTEM;Password=123456789;Data Source=localhost:1521";
            //con.Open();
            //Console.WriteLine("Connected to Oracle" + con.ServerVersion);

            //// Close and Dispose OracleConnection object
            //con.Close();
            //con.Dispose();
            //Console.WriteLine("Disconnected");
        }
    }


}
