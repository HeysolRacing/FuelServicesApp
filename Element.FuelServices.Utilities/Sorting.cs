using Element.FuelServices.Shared.Entities.Operation;
using Element.FuelServices.Shared.Enum;
using System.Collections.Generic;
using System.Linq;

namespace Element.FuelServices.Utilities
{
    public static class Sorting
    {
        public static IList<FuelStation> Sort(IList<FuelStation> list, EnumProduct product)
        {
            var sortedList = list;

            switch (product)
            {
                case EnumProduct.Diesel:
                    sortedList = list.OrderBy(o => o.Diesel).ToList();
                    break;
                case EnumProduct.Magna:
                    sortedList = list.OrderBy(o => o.Magna).ToList();
                    break;
                case EnumProduct.Premium:
                    sortedList = list.OrderBy(o => o.Premium).ToList();
                    break;
                case EnumProduct.NotSpecified:
                default:
                    break;
            };

            return sortedList;
        }
    }
}