using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.DTO
{
    [DataContract(IsReference = true)]
    public partial class LocationDTO
    {
        public LocationDTO()
        {
            this.Name = "";
            this.Scenery = "";
            this.ZipCode = "";
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Scenery { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public Nullable<decimal> Longitude { get; set; }

        [DataMember]
        public Nullable<decimal> Latitude { get; set; }

        [DataMember]
        public int MultimediaId { get; set; }

        [DataMember]
        public MultimediaDTO Multimedia { get; set; }
    }
}
