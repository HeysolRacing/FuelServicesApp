using System.Runtime.Serialization;

namespace Element.FuelServices.Shared.Enum
{
    [DataContract]
    public enum EnumProduct
    {
        [EnumMember]
        NotSpecified = 0,

        [EnumMember]
        Diesel = 1,

        [EnumMember]
        Magna = 2,

        [EnumMember]
        Premium = 3
    }
}