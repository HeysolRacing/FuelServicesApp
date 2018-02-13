using Element.FuelServices.Shared.Dto;
using System.ServiceModel;

namespace Element.FuelServices.Services.Operation
{
    [ServiceContract]
    public interface IStationList
    {
        [OperationContract]
        Response Get(StationListRequest request);
    }
}