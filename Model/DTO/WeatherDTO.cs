using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.DTO
{
    [DataContract]
    [Flags]
    public enum WeatherDTO : byte
    {
        [EnumMember]
        Sunny = 0,

        [EnumMember]
        Cloudy = 1,

        [EnumMember]
        PartlyCloudy = 2,

        [EnumMember]
        Rainy = 3,

        [EnumMember]
        Snowy = 4,

        [EnumMember]
        Sleeting = 5,

        [EnumMember]
        Stormy = 6,

        [EnumMember]
        Lightning = 7,

        [EnumMember]
        Thunderous = 8,

        [EnumMember]
        Hailing = 9,

        [EnumMember]
        Windy = 10,

        [EnumMember]
        Foggy = 11,

        [EnumMember]
        Icy = 12,

        [EnumMember]
        None = 13
    }
}
