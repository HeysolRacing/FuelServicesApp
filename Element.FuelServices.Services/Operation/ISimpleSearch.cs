using Element.FuelServices.Shared.Dto;
using System.ServiceModel;

namespace Element.FuelServices.Services.Operation
{
    [ServiceContract]
    public interface ISimpleSearch
    {
        [OperationContract]
        Response Get(SimpleSearchRequest request);
    }
}