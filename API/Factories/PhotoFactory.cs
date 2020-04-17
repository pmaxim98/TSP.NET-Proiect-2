using MyPhotos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Factories
{
    public class PhotoFactory
    {
        public static void Update(Photo oldPhoto, Photo newPhoto)
        {
            oldPhoto.X = newPhoto.X;
            oldPhoto.Y = newPhoto.Y;
            oldPhoto.Width = newPhoto.Width;
            oldPhoto.Height = newPhoto.Height;
        }

        public static Photo Create(Photo other)
        {
            Photo photo = new Photo()
            {
                Id = other.Id,
                X = other.X,
                Y = other.Y,
                Width = other.Width,
                Height = other.Height,
                Person = other.Person
            };

            return photo;
        }
    }
}
