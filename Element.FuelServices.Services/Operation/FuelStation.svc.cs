using Element.FuelServices.Domain.Operation;
using Element.FuelServices.Shared.Dto;

namespace Element.FuelServices.Services.Operation
{
    public class FuelStation : IFuelStation
    {
        private FuelStationBr _fuelStationBr;

        public FuelStation()
        {
            _fuelStationBr = new FuelStationBr("FuelServicesConnection");
        }

        public Response GetAll()
        {
            return _fuelStationBr.GetAll();
        }
    }
}