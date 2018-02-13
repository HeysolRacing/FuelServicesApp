using Element.FuelServices.DataAccess.Dac;
using Element.FuelServices.Shared.Dto;
using Element.FuelServices.Shared.Entities.Operation;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Element.FuelServices.DataAccess.Dao.Operation
{
    internal sealed class FuelStationDa : DataAccessComponent
    {
        private IList<FuelStation> _listResult;

        internal FuelStationDa(IDbConnection connection)
            : base(connection)
        {
        }

        internal IList<FuelStation> GetAll()
        {
            Command = new SqlCommand
            {
                Connection = (SqlConnection)Connection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "Operation.FuelStationSel"
            };

            Populate((SqlDataReader)Command.ExecuteReader());

            return _listResult;
        }

        internal IList<FuelStation> GetCityState(CityStateRequest filter)
        {
            Command = new SqlCommand
            {
                Connection = (SqlConnection)Connection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "Operation.GetCityState"
            };

            var param = new SqlParameter
            {
                ParameterName = "@SupplierID",
                DbType = DbType.Int32,
                Value = filter.SupplierId
            };

            Command.Parameters.Add(param);

            if (!string.IsNullOrEmpty(filter.City))
            {
                var paramOpc = new SqlParameter
                {
                    ParameterName = "@City",
                    DbType = DbType.String,
                    Value = filter.City
                };

                Command.Parameters.Add(paramOpc);
            }

            if (!string.IsNullOrEmpty(filter.State))
            {
                var paramOpc = new SqlParameter
                {
                    ParameterName = "@State",
                    DbType = DbType.String,
                    Value = filter.State
                };

                Command.Parameters.Add(paramOpc);
            }

            Populate((SqlDataReader)Command.ExecuteReader());

            return _listResult;
        }

        internal IList<FuelStation> GetZipCode(ZipCodeRequest filter)
        {
            Command = new SqlCommand
            {
                Connection = (SqlConnection)Connection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "Operation.GetZipCode"
            };

            var param = new SqlParameter
            {
                ParameterName = "@ZipCode",
                DbType = DbType.String,
                Value = filter.ZipCode
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@SupplierID",
                DbType = DbType.Int32,
                Value = filter.SupplierId
            };

            Command.Parameters.Add(param);

            Populate((SqlDataReader)Command.ExecuteReader());

            return _listResult;
        }

        internal IList<FuelStation> GetStation(StationListRequest filter)
        {
            Command = new SqlCommand
            {
                Connection = (SqlConnection)Connection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "Operation.GetStation"
            };

            var param = new SqlParameter
            {
                ParameterName = "@ServiceStationID",
                DbType = DbType.String,
                Value = filter.StationList
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@SupplierID",
                DbType = DbType.Int32,
                Value = filter.SupplierId
            };

            Command.Parameters.Add(param);

            Populate((SqlDataReader)Command.ExecuteReader());

            return _listResult;
        }

        internal IList<FuelStation> Search(SimpleSearchRequest filter)
        {
            Command = new SqlCommand
            {
                Connection = (SqlConnection)Connection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "Operation.SearchCityStateZipCodeSimple"
            };

            if (!string.IsNullOrEmpty(filter.City))
            {
                var paramOpc = new SqlParameter
                {
                    ParameterName = "@City",
                    DbType = DbType.String,
                    Value = filter.City
                };

                Command.Parameters.Add(paramOpc);
            }

            if (!string.IsNullOrEmpty(filter.State))
            {
                var paramOpc = new SqlParameter
                {
                    ParameterName = "@State",
                    DbType = DbType.String,
                    Value = filter.State
                };

                Command.Parameters.Add(paramOpc);
            }

            if (!string.IsNullOrEmpty(filter.ZipCode))
            {
                var paramOpc = new SqlParameter
                {
                    ParameterName = "@ZipCode",
                    DbType = DbType.String,
                    Value = filter.ZipCode
                };

                Command.Parameters.Add(paramOpc);
            }

            var param = new SqlParameter
            {
                ParameterName = "@Product",
                DbType = DbType.String,
                Value = filter.ProductName
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@SupplierID",
                DbType = DbType.String,
                Value = filter.SupplierId
            };

            Command.Parameters.Add(param);

            Populate((SqlDataReader)Command.ExecuteReader());

            return _listResult;
        }

        internal IList<FuelStation> Search(AdvancedSearchRequest filter)
        {
            Command = new SqlCommand
            {
                Connection = (SqlConnection)Connection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "Operation.Search"
            };

            if (!string.IsNullOrEmpty(filter.IdStation))
            {
                var paramOpc = new SqlParameter
                {
                    ParameterName = "@IdStation",
                    DbType = DbType.String,
                    Value = filter.IdStation
                };

                Command.Parameters.Add(paramOpc);
            }

            if (!string.IsNullOrEmpty(filter.ZipCode))
            {
                var paramOpc = new SqlParameter
                {
                    ParameterName = "@ZipCode",
                    DbType = DbType.String,
                    Value = filter.ZipCode
                };

                Command.Parameters.Add(paramOpc);
            }

            var param = new SqlParameter
            {
                ParameterName = "@LowestNPrices",
                DbType = DbType.Int32,
                Value = filter.LowestNPrices
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@NDaysOldPrices",
                DbType = DbType.Int32,
                Value = filter.NDaysOldPrices
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@ShowAllOnNoPrices",
                DbType = DbType.Boolean,
                Value = filter.ShowAllOnNoPrices
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@Product",
                DbType = DbType.Boolean,
                Value = filter.ProductName
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@SupplierID",
                DbType = DbType.Boolean,
                Value = filter.SupplierId
            };

            Command.Parameters.Add(param);

            Populate((SqlDataReader)Command.ExecuteReader());

            return _listResult;
        }

        internal IList<FuelStationDetail> GetLatLongSortedWithDistanceResults(LatLongRequest filter)
        {
            IList<FuelStationDetail> listResult = new List<FuelStationDetail>();

            Command = new SqlCommand
            {
                Connection = (SqlConnection)Connection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "Operation.GetLatLongSortedWithDistanceResults"
            };

            var param = new SqlParameter
            {
                ParameterName = "@Lattitude",
                DbType = DbType.Decimal,
                Value = filter.Lattitude
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@Longitude",
                DbType = DbType.Decimal,
                Value = filter.Longitude
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@FuelType",
                DbType = DbType.String,
                Value = filter.FuelType
            };

            Command.Parameters.Add(param);

            param = new SqlParameter
            {
                ParameterName = "@Distance",
                DbType = DbType.Decimal,
                Value = filter.Distance
            };

            Command.Parameters.Add(param);

            listResult = Populate2((SqlDataReader)Command.ExecuteReader());

            return listResult;
        }

        private IList<FuelStation> Populate(SqlDataReader reader)
        {
            _listResult = new List<FuelStation>();

            while (reader.Read())
            {
                _listResult.Add(new FuelStation
                {
                    StationId = reader.GetInt32(reader.GetOrdinal("StationID")),
                    Station = reader.GetString(reader.GetOrdinal("Station")),
                    ServiceStation = reader.GetString(reader.GetOrdinal("ServiceStation")),
                    Lattitude = reader.GetDecimal(reader.GetOrdinal("Lattitude")),
                    Longitude = reader.GetDecimal(reader.GetOrdinal("Longitude")),
                    ZipCode = reader.GetString(reader.GetOrdinal("ZipCode")),
                    SupplierId = reader.GetInt32(reader.GetOrdinal("SupplierID")),
                    SupplierName = reader.GetString(reader.GetOrdinal("SupplierName")),
                    Diesel = reader.GetDecimal(reader.GetOrdinal("Diesel")),
                    Magna = reader.GetDecimal(reader.GetOrdinal("Magna")),
                    Premium = reader.GetDecimal(reader.GetOrdinal("Premium")),
                    TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate")),
                });
            }

            return _listResult;
        }

        private IList<FuelStationDetail> Populate2(SqlDataReader reader)
        {
            var listResult = new List<FuelStationDetail>();

            while (reader.Read())
            {
                listResult.Add(new FuelStationDetail
                {
                    StationName = reader.GetString(reader.GetOrdinal("StationName")),
                    Address1 = reader.GetString(reader.GetOrdinal("Address1")),
                    City = reader.GetString(reader.GetOrdinal("City")),
                    State = reader.GetString(reader.GetOrdinal("State")),
                    Zip = reader.GetString(reader.GetOrdinal("Zip")),
                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                    BrandName = reader.GetString(reader.GetOrdinal("BrandName")),
                    UnleadedPrice = reader.GetDecimal(reader.GetOrdinal("UnleadedPrice")),
                    PremiumPrice = reader.GetDecimal(reader.GetOrdinal("PremiumPrice")),
                    DieselPrice = reader.GetDecimal(reader.GetOrdinal("DieselPrice")),
                    Latitude = reader.GetDecimal(reader.GetOrdinal("Lattitude")),
                    Longitude = reader.GetDecimal(reader.GetOrdinal("Longitude")),
                    DistanceToStation = reader.GetDecimal(reader.GetOrdinal("DistanceToStation")),
                    StationId = reader.GetInt32(reader.GetOrdinal("StationID")),
                    UnleadedId = reader.GetInt32(reader.GetOrdinal("UnleadedID")),
                    PremiumId = reader.GetInt32(reader.GetOrdinal("PremiumID")),
                    DieselId = reader.GetInt32(reader.GetOrdinal("DieselID")),
                    UnleadedDate = reader.GetDateTime(reader.GetOrdinal("UnleadedDate")),
                    DieselDate = reader.GetDateTime(reader.GetOrdinal("DieselDate")),
                    PremiumDate = reader.GetDateTime(reader.GetOrdinal("PremiumDate")),
                    SupplierId = reader.GetInt32(reader.GetOrdinal("SupplierId"))
                });
            }

            return listResult;
        }
    }
}