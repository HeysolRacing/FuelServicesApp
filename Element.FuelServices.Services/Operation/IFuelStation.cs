using Element.FuelServices.Shared.Dto;
using System.ServiceModel;

namespace Element.FuelServices.Services.Operation
{
    [ServiceContract]
    public interface IFuelStation
    {
        [OperationContract]
        Response GetAll();
    }
}