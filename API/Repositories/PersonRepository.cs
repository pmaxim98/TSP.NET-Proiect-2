using MyPhotos.Model;
using MyPhotos.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(MyPhotosContainer context) : base(context)
        {
            
        }
    }
}
