using Element.FuelServices.Shared.Entities.Operation;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Dto
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public bool IsSuccess { get; set; }

        [DataMember]
        public IList<FuelStationDetail> ListResult { get; set; }

        [DataMember]
        public int NumberItems { get; set; }

        [DataMember]
        public StatusResponse StatusResponse { get; set; }
    }
}