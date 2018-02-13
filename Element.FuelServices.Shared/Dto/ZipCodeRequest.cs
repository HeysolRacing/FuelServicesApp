using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Dto
{
    [DataContract]
    public class ZipCodeRequest : CommonRequest
    {
        [DataMember]
        public string ZipCode { get; set; }
    }
}