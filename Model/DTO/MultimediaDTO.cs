using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.DTO
{
    [DataContract(IsReference = true)]
    public partial class MultimediaDTO
    {
        public MultimediaDTO()
        {
            this.Description = "";
            this.Event = "";
            this.Deleted = false;
            this.AdditionalLabels = "";
            this.People = new List<PersonDTO>();
            this.Locations = new List<LocationDTO>();
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Event { get; set; }

        [DataMember]
        public WeatherDTO Weather { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public DateTime DateAdded { get; set; }

        [DataMember]
        public DateTime DateModified { get; set; }

        [DataMember]
        public bool Deleted { get; set; }

        [DataMember]
        public string AdditionalLabels { get; set; }

        [DataMember]
        public List<PersonDTO> People { get; set; }

        [DataMember]
        public List<LocationDTO> Locations { get; set; }
    }
}
