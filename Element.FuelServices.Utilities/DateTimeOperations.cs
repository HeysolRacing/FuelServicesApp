using System;

namespace Element.FuelServices.Utilities
{
    public static class DateTimeOperations
    {
        public static string FormatTimeStamp()
        {
            var currentDate = DateTime.Now;
            var year = currentDate.Year;
            var month = currentDate.Month.ToString().Length > 1 ? currentDate.Month.ToString() : $"0{currentDate.Month.ToString()}";
            var day = currentDate.Day.ToString().Length > 1 ? currentDate.Day.ToString() : $"0{currentDate.Day.ToString()}";
            var hour = currentDate.Hour.ToString().Length > 1 ? currentDate.Hour.ToString() : $"0{currentDate.Hour.ToString()}";
            var minute = currentDate.Minute.ToString().Length > 1 ? currentDate.Minute.ToString() : $"0{currentDate.Minute.ToString()}";
            var second = currentDate.Second.ToString().Length > 1 ? currentDate.Second.ToString() : $"0{currentDate.Second.ToString()}";
            var millisecond = currentDate.Millisecond;

            return $"{year}-{month}-{day} {hour}:{minute}:{second}.{millisecond}";
        }
    }
}