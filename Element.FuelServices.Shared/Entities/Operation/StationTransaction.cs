using System;

namespace Element.FuelServices.Shared.Entities.Operation
{
    public class StationTransaction
    {
        public long StationTranID { get; set; }

        public long StationSupplierID { get; set; }

        public decimal Price { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}