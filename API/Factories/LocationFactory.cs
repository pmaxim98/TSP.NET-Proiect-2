using MyPhotos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Factories
{
    public class LocationFactory
    {
        public static void Update(Location oldLocation, Location newLocation)
        {
            oldLocation.Latitude = newLocation.Latitude;
            oldLocation.Longitude = newLocation.Longitude;
            oldLocation.Name = newLocation.Name;
            oldLocation.Scenery = newLocation.Scenery;
            oldLocation.ZipCode = newLocation.ZipCode;
        }

        public static Location Create(Location other)
        {
            Location location = new Location()
            {
                Id = other.Id,
                Latitude = other.Latitude,
                Longitude = other.Longitude,
                Name = other.Name,
                Scenery = other.Scenery,
                ZipCode = other.ZipCode,
                MultimediaId = other.Id
            };

            return location;
        }
    }
}
