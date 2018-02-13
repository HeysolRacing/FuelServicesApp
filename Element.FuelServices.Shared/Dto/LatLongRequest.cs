using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Dto
{
    [DataContract]
    public class LatLongRequest : CommonRequest
    {
        [DataMember]
        public decimal Lattitude { get; set; }

        [DataMember]
        public decimal Longitude { get; set; }

        [DataMember]
        public string FuelType { get; set; }

        [DataMember]
        public decimal Distance { get; set; }

        public string UserToken { get; set; }
    }
}