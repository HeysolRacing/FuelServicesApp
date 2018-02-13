using Element.FuelServices.Domain.Operation;
using Element.FuelServices.Shared.Dto;

namespace Element.FuelServices.Services.Operation
{
    public class LattitudeLongitude : ILattitudeLongitude
    {
        private FuelStationBr _fuelStationBr;

        public LattitudeLongitude()
        {
            _fuelStationBr = new FuelStationBr("FuelServicesConnection");
        }

        public Response Get(LatLongRequest request)
        {
            return _fuelStationBr.GetLatLongSortedWithDistanceResults(request);
        }
    }
}