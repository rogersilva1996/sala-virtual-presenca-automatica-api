using Dapper;
using SalaVirtual.Repositories.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVirtual.Repositories
{
    public class SingInClassRepository : ISingInClassRepository
    {
        private readonly IDbOracleConnection _dbOracleConnection;

        public SingInClassRepository(IDbOracleConnection dbOracleConnection)
        {
            _dbOracleConnection = dbOracleConnection;
        }

        public IList<int> ClassExist(string codigoSala)
        {
            try
            {
                string query = "select * from tb_salas where codigo_sala = '" + codigoSala + "'";

                IList<int> consulta = _dbOracleConnection.Dbconnection().Query<int>(query).AsList();

                return consulta;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void SingIn(string email, string codigoSala, string numeroIdentificacao)
        {
            try
            {
                string query = "declare " +
                               "vRetorno int; " +
                               "begin " +
                               "sp_acesso_sala ('" + email +
                                                 "','" + codigoSala +
                                                 "','" + numeroIdentificacao +
                                                 "'," +
                                                 " pRetorno => vRetorno); " +
                               "end;";

                IList<int> result = _dbOracleConnection.Dbconnection().Query<int>(query).AsList();

            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
