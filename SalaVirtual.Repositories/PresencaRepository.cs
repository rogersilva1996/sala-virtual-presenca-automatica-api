using Dapper;
using SalaVirtual.Repositories.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVirtual.Repositories
{
    public class PresencaRepository : IPresencaRepository
    {
        private readonly IDbOracleConnection _dbOracleConnection;

        public PresencaRepository(IDbOracleConnection dbOracleConnection)
        {
            _dbOracleConnection = dbOracleConnection;
        }

        public void Presenca(string codigoSala)
        {
            try
            {
                _dbOracleConnection.Dbconnection().Query("begin sp_presenca_sala('" + codigoSala + "'); end;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
