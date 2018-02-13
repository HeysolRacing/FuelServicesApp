using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Dto
{
    [DataContract]
    public class StatusResponse
    {
        [DataMember]
        public int Status { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Timestamp { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}