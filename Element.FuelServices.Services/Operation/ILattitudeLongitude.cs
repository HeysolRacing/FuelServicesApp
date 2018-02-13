using Element.FuelServices.Shared.Dto;
using System.ServiceModel;

namespace Element.FuelServices.Services.Operation
{
    [ServiceContract]
    public interface ILattitudeLongitude
    {
        [OperationContract]
        Response Get(LatLongRequest request);
    }
}