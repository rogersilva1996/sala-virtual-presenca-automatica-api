using Dapper;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;
using SalaVirtual.Util.Environment;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalaVirtual.Repositories
{
    public class CreateAcoutRepository : ICreateAcoutRepository
    {
        private readonly Connection _connection;

        public CreateAcoutRepository(IOptions<Connection> connection)
        {
            _connection = connection.Value;
        }

        public void CreateAcout(string nome, string email, string senha)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (OracleConnection conn = new OracleConnection(_connection.connectionString))
                {
                    conn.Open();

                    IList<int> conferencia = conn.Query<int>("select * from tb_usuario where email_usuario = '" + email + "'").AsList();

                    if(conferencia.Count == 0)
                    {
                        string query = "declare " +
                                       "vRetorno int; " +
                                       "begin " +
                                       "sp_insert_cadastro ('" + nome + "','" + email + "','" + senha + "', pRetorno => vRetorno); " +
                                       "end;";


                        IList<int> test = conn.Query<int>(query).AsList();
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
