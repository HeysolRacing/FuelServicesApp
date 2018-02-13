using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Dto
{
    [DataContract]
    public class StationListRequest : CommonRequest
    {
        [DataMember]
        /// <summary>
        /// Specific comma-separated list of station ID
        /// </summary>
        public string StationList { get; set; }
    }
}