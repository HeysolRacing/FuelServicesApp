using Element.FuelServices.Shared.Enum;
using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Dto
{
    [DataContract]
    public class CommonRequest
    {
        [DataMember]
        public string UserTicket { get; set; }

        [DataMember]
        public EnumProduct? SortedBy { get; set; }

        [DataMember]
        public int SupplierId { get; set; }
    }
}