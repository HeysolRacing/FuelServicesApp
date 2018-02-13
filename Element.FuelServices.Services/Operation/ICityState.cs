using Element.FuelServices.Shared.Dto;
using System.ServiceModel;

namespace Element.FuelServices.Services.Operation
{
    [ServiceContract]
    public interface ICityState
    {
        [OperationContract]
        Response Get(CityStateRequest request);
    }
}