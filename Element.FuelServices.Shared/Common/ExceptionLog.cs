using System;

namespace Element.FuelServices.Shared.Common
{
    public class ExceptionLog
    {
        public int ExceptionId { get; set; }

        public string ApplicationName { get; set; }

        public string Message { get; set; }

        public DateTime ThrowingDate { get; set; }
    }
}