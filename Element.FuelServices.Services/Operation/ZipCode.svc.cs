using Element.FuelServices.Domain.Operation;
using Element.FuelServices.Shared.Dto;

namespace Element.FuelServices.Services.Operation
{
    public class ZipCode : IZipCode
    {
        private FuelStationBr _fuelStationBr;

        public ZipCode()
        {
            _fuelStationBr = new FuelStationBr("FuelServicesConnection");
        }

        public Response Get(ZipCodeRequest request)
        {
            return _fuelStationBr.GetZipCode(request);
        }
    }
}