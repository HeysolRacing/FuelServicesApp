using Element.FuelServices.Domain.Operation;
using Element.FuelServices.Shared.Dto;

namespace Element.FuelServices.Services.Operation
{
    public class AdvancedSearch : IAdvancedSearch
    {
        private FuelStationBr _fuelStationBr;

        public AdvancedSearch()
        {
            _fuelStationBr = new FuelStationBr("FuelServicesConnection");
        }

        public Response Get(AdvancedSearchRequest request)
        {
            return _fuelStationBr.Search(request);
        }
    }
}