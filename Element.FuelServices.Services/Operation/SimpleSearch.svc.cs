using Element.FuelServices.Domain.Operation;
using Element.FuelServices.Shared.Dto;

namespace Element.FuelServices.Services.Operation
{
    public class SimpleSearch : ISimpleSearch
    {
        private FuelStationBr _fuelStationBr;

        public SimpleSearch()
        {
            _fuelStationBr = new FuelStationBr("FuelServicesConnection");
        }

        public Response Get(SimpleSearchRequest request)
        {
            return _fuelStationBr.Search(request);
        }
    }
}