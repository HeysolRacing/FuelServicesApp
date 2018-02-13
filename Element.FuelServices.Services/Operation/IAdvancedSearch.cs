using Element.FuelServices.Shared.Dto;
using System.ServiceModel;

namespace Element.FuelServices.Services.Operation
{
    [ServiceContract]
    public interface IAdvancedSearch
    {
        [OperationContract]
        Response Get(AdvancedSearchRequest request);
    }
}