using System.Data;

namespace Element.FuelServices.DataAccess.Dac
{
    internal class DataAccessComponent
    {
        protected internal IDbConnection Connection;
        protected internal IDbCommand Command;

        internal DataAccessComponent(IDbConnection connection)
        {
            Connection = connection;
        }
    }
}