using System;
using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Entities.Operation
{
    [DataContract]
    public class FuelStation
    {
        [DataMember]
        public int StationId { get; set; }

        [DataMember]
        public string Station { get; set; }

        [DataMember]
        public string ServiceStation { get; set; }

        [DataMember]
        public decimal Lattitude { get; set; }

        [DataMember]
        public decimal Longitude { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public int SupplierId { get; set; }

        [DataMember]
        public string SupplierName { get; set; }

        [DataMember]
        public decimal Diesel { get; set; }

        [DataMember]
        public decimal Magna { get; set; }

        [DataMember]
        public decimal Premium { get; set; }

        [DataMember]
        public DateTime TransactionDate { get; set; }
    }
}