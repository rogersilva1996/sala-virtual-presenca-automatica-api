using Oracle.ManagedDataAccess.Client;

namespace SalaVirtual.Repositories.DataAccess
{
    public interface IDbOracleConnection
    {
        OracleConnection Dbconnection();
    }
}