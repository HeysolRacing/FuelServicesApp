using Element.FuelServices.DataAccess.Dac;
using Element.FuelServices.Shared.Common;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Element.FuelServices.DataAccess.Dao.Maintenance
{
    internal sealed class ExceptionLogDa : DataAccessComponent
    {
        public ExceptionLogDa(IDbConnection connection)
            : base(connection)
        {
        }

        internal long Add(ExceptionLog exceptionLog)
        {
            Command = new SqlCommand
            {
                Connection = (SqlConnection)Connection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "Auditoring.ExceptionLogIns"
            };

            var param = new SqlParameter
            {
                ParameterName = "@ApplicationName",
                DbType = DbType.String,
                Value = exceptionLog.ApplicationName
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@Message",
                DbType = DbType.String,
                Value = exceptionLog.Message
            };

            Command.Parameters.Add(param);

            var outPutParameter = new SqlParameter
            {
                ParameterName = "@ExceptionId",
                SqlDbType = SqlDbType.BigInt,
                Size = 8,
                Direction = ParameterDirection.Output
            };

            Command.Parameters.Add(outPutParameter);

            Command.ExecuteNonQuery();

            var insertedRows = outPutParameter.Value.ToString();

            return Convert.ToInt64(insertedRows);
        }
    }
}