using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Element.FuelServices.DataAccess.Repository
{
    public class BaseRepository
    {
        protected internal IDbConnection Connection;

        internal BaseRepository(string connectionName)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            Connection = new SqlConnection(connectionString);
        }
    }
}