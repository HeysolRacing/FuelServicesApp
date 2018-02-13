using Element.FuelServices.Domain.Operation;
using Element.FuelServices.Shared.Dto;

namespace Element.FuelServices.Services.Operation
{
    public class CityState : ICityState
    {
        private FuelStationBr _fuelStationBr;

        public CityState()
        {
            _fuelStationBr = new FuelStationBr("FuelServicesConnection");
        }

        public Response Get(CityStateRequest request)
        {
            return _fuelStationBr.GetCityState(request);
        }
    }
}