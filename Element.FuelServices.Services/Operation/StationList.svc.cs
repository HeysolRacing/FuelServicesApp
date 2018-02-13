using Element.FuelServices.Domain.Operation;
using Element.FuelServices.Shared.Dto;

namespace Element.FuelServices.Services.Operation
{
    public class StationList : IStationList
    {
        private FuelStationBr _fuelStationBr;

        public StationList()
        {
            _fuelStationBr = new FuelStationBr("FuelServicesConnection");
        }

        public Response Get(StationListRequest request)
        {
            return _fuelStationBr.GetStation(request);
        }
    }
}