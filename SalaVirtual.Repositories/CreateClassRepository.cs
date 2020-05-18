using Dapper;
using SalaVirtual.Repositories.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVirtual.Repositories
{
    public class CreateClassRepository : ICreateClassRepository
    {
       

        private readonly IDbOracleConnection _dbOracleConnection;
        private string vRetorno = "vRetorno";

        public CreateClassRepository(IDbOracleConnection dbOracleConnection)
        {
            _dbOracleConnection = dbOracleConnection;
        }

        public IList<int> ClassExist(string codigoSala)
        {
            string query = "select * from tb_salas where codigo_sala = '" + codigoSala + "'";

            IList<int> consulta = _dbOracleConnection.Dbconnection().Query<int>(query).AsList();

            return consulta;
        }


        public void CreateClass(string codigoSala, string nomeSala, string email,string nomeInstituicao, string numeroIdentificacao, string obseracao, int periodoValidade)
        {
            

            string query = "declare " +
                           "vRetorno int; " +
                           "begin " +
                           "sp_insert_salas ('" + codigoSala + 
                                             "','" + nomeSala + 
                                             "','" + email + 
                                             "','" + numeroIdentificacao + 
                                             "','" + nomeInstituicao + 
                                             "','" + obseracao + 
                                             "','" + periodoValidade + 
                                             "'," + 
                                             " pRetorno => vRetorno); " +
                           "end;";

            IList<int> test = _dbOracleConnection.Dbconnection().Query<int>(query).AsList();
        }
    }
}
