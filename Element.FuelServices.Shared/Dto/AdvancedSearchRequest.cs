using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Dto
{
    [DataContract]
    public class AdvancedSearchRequest : CommonRequest
    {
        [DataMember]
        public string IdStation { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public int LowestNPrices { get; set; }

        [DataMember]
        public int NDaysOldPrices { get; set; }

        [DataMember]
        public bool ShowAllOnNoPrices { get; set; }

        [DataMember]
        public string ProductName { get; set; }
    }
}