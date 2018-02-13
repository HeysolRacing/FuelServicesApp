using System;
using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Entities.Operation
{
    [DataContract]
    public class FuelStationDetail
    {
        [DataMember]
        public string StationName { get; set; }

        [DataMember]
        public string Address1 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string BrandName { get; set; }

        [DataMember]
        public decimal UnleadedPrice { get; set; }

        [DataMember]
        public decimal PremiumPrice { get; set; }

        [DataMember]
        public decimal DieselPrice { get; set; }

        [DataMember]
        public DateTime UnleadedDate { get; set; }

        [DataMember]
        public DateTime PremiumDate { get; set; }

        [DataMember]
        public DateTime DieselDate { get; set; }

        [DataMember]
        public decimal Latitude { get; set; }

        [DataMember]
        public decimal Longitude { get; set; }

        [DataMember]
        public decimal DistanceToStation { get; set; }

        [DataMember]
        public int StationId { get; set; }

        [DataMember]
        public int UnleadedId { get; set; }

        [DataMember]
        public int PremiumId { get; set; }

        [DataMember]
        public int DieselId { get; set; }

        [DataMember]
        public int SupplierId { get; set; }
    }
}