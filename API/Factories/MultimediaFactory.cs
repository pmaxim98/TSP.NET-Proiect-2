using MyPhotos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Factories
{
    public class MultimediaFactory
    {
        public static void Update(Multimedia oldMultimedia, Multimedia newMultimedia)
        {
            oldMultimedia.AdditionalLabels = newMultimedia.AdditionalLabels;
            oldMultimedia.DateAdded = newMultimedia.DateAdded;
            oldMultimedia.DateCreated = newMultimedia.DateCreated;
            oldMultimedia.DateModified = newMultimedia.DateModified;
            oldMultimedia.Deleted = newMultimedia.Deleted;
            oldMultimedia.Description = newMultimedia.Description;
            oldMultimedia.Event = newMultimedia.Event;
            oldMultimedia.Weather = newMultimedia.Weather;
        }

        public static Multimedia Create(Multimedia other)
        {
            Multimedia multimedia = new Multimedia()
            {
                Id = other.Id,
                AdditionalLabels = other.AdditionalLabels,
                DateAdded = other.DateAdded,
                DateCreated = other.DateCreated,
                DateModified = other.DateModified,
                Deleted = other.Deleted,
                Description = other.Description,
                Event = other.Event,
                Weather = other.Weather
            };

            return multimedia;
        }
    }
}
