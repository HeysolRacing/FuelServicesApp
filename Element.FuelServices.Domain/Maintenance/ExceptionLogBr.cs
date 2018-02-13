using Element.FuelServices.DataAccess.Repository.Maintenance;
using Element.FuelServices.Shared.Common;

namespace Element.FuelServices.Domain.Maintenance
{
    public class ExceptionLogBr
    {
        private readonly ExceptionLogRepository _repository;

        public ExceptionLogBr(string connectionName)
        {
            _repository = new ExceptionLogRepository(connectionName);
        }

        public long Add(ExceptionLog exceptionLog)
        {
            return _repository.Add(exceptionLog);
        }
    }
}