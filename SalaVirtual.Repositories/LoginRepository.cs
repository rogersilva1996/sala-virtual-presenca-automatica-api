using Dapper;
using SalaVirtual.Repositories.DataAccess;
using System;
using System.Collections.Generic;

namespace SalaVirtual.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private IDbOracleConnection _dbConnection;

        public LoginRepository(IDbOracleConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IList<int> Login(string email, string senha)
        {
            try
            {
                IList<int> consulta = _dbConnection.Dbconnection().Query<int>("SELECT fn_verifica_login ('" + email + "'" + ",'" + senha + "') FROM dual").AsList();

                return consulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
