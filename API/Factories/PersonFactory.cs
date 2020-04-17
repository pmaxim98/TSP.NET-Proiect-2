using MyPhotos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Factories
{
    public class PersonFactory
    {
        public static void Update(Person oldPerson, Person newPerson)
        {
            oldPerson.FirstName = newPerson.FirstName;
            oldPerson.LastName = newPerson.LastName;
            oldPerson.Age = newPerson.Age;
        }

        public static Person Create(Person other)
        {
            Person person = new Person()
            {
                Id = other.Id,
                FirstName = other.FirstName,
                LastName = other.LastName,
                Age = other.Age,
                MultimediaId = other.MultimediaId
            };

            return person;
        }
    }
}
