using Element.FuelServices.DataAccess.Dao.Maintenance;
using Element.FuelServices.Shared.Common;
using System.Data;

namespace Element.FuelServices.DataAccess.Repository.Maintenance
{
    public sealed class ExceptionLogRepository : BaseRepository
    {
        private readonly ExceptionLogDa _exceptionLogDa;

        public ExceptionLogRepository(string connectionName)
            : base(connectionName)

        {
            _exceptionLogDa = new ExceptionLogDa(Connection);
        }

        public long Add(ExceptionLog exceptionLog)
        {
            long id = 0;

            try
            {
                Connection.Open();
                id = _exceptionLogDa.Add(exceptionLog);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

            return id;
        }
    }
}