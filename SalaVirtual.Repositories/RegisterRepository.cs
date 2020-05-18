using Dapper;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;
using SalaVirtual.Repositories.DataAccess;
using SalaVirtual.Util.Environment;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalaVirtual.Repositories
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly IDbOracleConnection _dbOracleConnection;

        public RegisterRepository(IDbOracleConnection dbOracleConnection, IOptions<Connection> connection)
        {
            _dbOracleConnection = dbOracleConnection;
        }

        public IList<int> ValidateCreateAcout(string email)
        {
            try
            {
                IList<int> conferencia = _dbOracleConnection.Dbconnection().Query<int>("select * from tb_usuario where email_usuario = '" + email + "'").AsList();

                return conferencia;
            }
            catch(Exception ex)
            {
                throw ex;
            }
          
        }

        public void CreateAcout(string nome, string email, string senha)
        {
            try
            {

                string query = "declare " +
                               "vRetorno int; " +
                               "begin " +
                               "sp_insert_cadastro ('" + nome + "','" + email + "','" + senha + "', pRetorno => vRetorno); " +
                               "end;";

                IList<int> test = _dbOracleConnection.Dbconnection().Query<int>(query).AsList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
