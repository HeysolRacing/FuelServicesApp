using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Dto
{
    [DataContract]
    public class CityStateRequest : CommonRequest
    {
        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }
    }
}