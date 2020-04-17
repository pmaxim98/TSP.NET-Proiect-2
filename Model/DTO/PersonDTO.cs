using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.DTO
{
    [DataContract(IsReference = true)]
    public partial class PersonDTO
    {
        public PersonDTO()
        {
            this.FirstName = "";
            this.LastName = "";
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public Nullable<short> Age { get; set; }

        [DataMember]
        public int MultimediaId { get; set; }

        [DataMember]
        public MultimediaDTO Multimedia { get; set; }

        [DataMember]
        public PhotoDTO Photo { get; set; }
    }
}
