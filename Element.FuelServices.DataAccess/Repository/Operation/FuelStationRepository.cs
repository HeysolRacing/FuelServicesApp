using Element.FuelServices.DataAccess.Dao.Operation;
using Element.FuelServices.Shared.Dto;
using Element.FuelServices.Shared.Entities.Operation;
using System.Collections.Generic;
using System.Data;

namespace Element.FuelServices.DataAccess.Repository.Operation
{
    public class FuelStationRepository : BaseRepository
    {
        private readonly FuelStationDa _fuelStationDa;
        private IList<FuelStation> _listResult;

        public FuelStationRepository(string connectionName)
            : base(connectionName)
        {
            _fuelStationDa = new FuelStationDa(Connection);
        }

        public IList<FuelStation> GetAll()
        {
            _listResult = null;

            try
            {
                Connection.Open();
                _listResult = _fuelStationDa.GetAll();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

            return _listResult;
        }

        public IList<FuelStation> GetCityState(CityStateRequest filter)
        {
            _listResult = null;

            try
            {
                Connection.Open();
                _listResult = _fuelStationDa.GetCityState(filter);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

            return _listResult;
        }

        public IList<FuelStation> GetZipCode(ZipCodeRequest filter)
        {
            _listResult = null;

            try
            {
                Connection.Open();
                _listResult = _fuelStationDa.GetZipCode(filter);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

            return _listResult;
        }

        public IList<FuelStation> GetStation(StationListRequest filter)
        {
            _listResult = null;

            try
            {
                Connection.Open();
                _listResult = _fuelStationDa.GetStation(filter);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

            return _listResult;
        }

        public IList<FuelStation> Search(SimpleSearchRequest filter)
        {
            _listResult = null;

            try
            {
                Connection.Open();
                _listResult = _fuelStationDa.Search(filter);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

            return _listResult;
        }

        public IList<FuelStation> Search(AdvancedSearchRequest filter)
        {
            _listResult = null;

            try
            {
                Connection.Open();
                _listResult = _fuelStationDa.Search(filter);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

            return _listResult;
        }

        public IList<FuelStationDetail> GetLatLongSortedWithDistanceResults(LatLongRequest filter)
        {
            IList<FuelStationDetail> _listResult = null;

            try
            {
                Connection.Open();
                _listResult = _fuelStationDa.GetLatLongSortedWithDistanceResults(filter);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }

            return _listResult;
        }
    }
}