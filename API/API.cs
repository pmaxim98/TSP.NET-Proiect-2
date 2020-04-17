using MyPhotos.Factories;
using MyPhotos.Model;
using MyPhotos.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class API
    {
        public static void AddMultimedia(Multimedia multimedia)
        {
            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                unitOfWork.Multimedia.Add(multimedia);

                unitOfWork.Save();
            }
        }

        public static Multimedia GetMultimediaById(int id)
        {
            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                return unitOfWork.Multimedia.Include(m => m.Locations).Include(m => m.People.Select(p => p.Photo)).First(m => m.Id == id);
            }
        }

        public static List<Multimedia> GetEveryMultimedia()
        {
            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                return unitOfWork.Multimedia.Include(m => m.Locations).Include(m => m.People.Select(p => p.Photo)).Where(m => m.Deleted == false).ToList(); //unitOfWork.Multimedia.Search(m => m.Deleted == false).ToList();
            }
        }

        public static Multimedia UpdateMultimedia(Multimedia multimedia)
        {
            if (multimedia == null)
                return null;

            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                Multimedia oldMultimedia = unitOfWork.Multimedia.GetById(multimedia.Id);

                if (oldMultimedia == null)
                    return null;

                MultimediaFactory.Update(oldMultimedia, multimedia);

                unitOfWork.Save();

                return oldMultimedia;
            }
        }

        public static void FlagMultimediaAsDeleted(int id)
        {
            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                Multimedia m = unitOfWork.Multimedia.GetById(id);

                if (m == null)
                    return;

                m.Deleted = true;
               
                unitOfWork.Save();
            }
        }

        public static void UpdateWholeMultimedia(Multimedia newMultimedia)
        {
            UpdateMultimedia(newMultimedia);

            RemoveLocations(newMultimedia);

            foreach (Location newLocation in newMultimedia.Locations)
                if (newLocation.Id == 0)
                    AddLocation(newMultimedia.Id, newLocation);
                else
                    UpdateLocation(newLocation);

            RemovePeople(newMultimedia);

            foreach (Person newPerson in newMultimedia.People)
                if (newPerson.Id == 0)
                    AddPerson(newMultimedia.Id, newPerson);
                else
                    UpdatePerson(newPerson);
        }

        public static Location GetLocationById(int id)
        {
            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                return unitOfWork.Locations.GetById(id);
            }
        }

        public static bool AddLocation(int multimediaId, Location location)
        {
            if (location == null)
                return false;

            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                location.MultimediaId = multimediaId;
                unitOfWork.Locations.Add(location);

                unitOfWork.Save();
                return true;
            }
        }

        public static bool UpdateLocation(Location location)
        {
            if (location == null)
                return false;

            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                Location oldLocation = unitOfWork.Locations.GetById(location.Id);

                if (oldLocation == null)
                    return false;

                LocationFactory.Update(oldLocation, location);

                unitOfWork.Save();
                return true;
            }
        }

        public static void RemoveLocations(Multimedia multimedia)
        {
            if (multimedia == null)
                return;

            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                Multimedia oldMultimedia = unitOfWork.Multimedia.GetById(multimedia.Id);

                if (oldMultimedia == null)
                    return;

                foreach (Location oldLocation in oldMultimedia.Locations.ToList())
                    if (!multimedia.Locations.Any(l => l.Id == oldLocation.Id))
                        unitOfWork.Locations.Remove(oldLocation);

                unitOfWork.Save();
            }
        }

        public static void RemovePeople(Multimedia multimedia)
        {
            if (multimedia == null)
                return;

            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                Multimedia oldMultimedia = unitOfWork.Multimedia.GetById(multimedia.Id);

                if (oldMultimedia == null)
                    return;

                foreach (Person oldPerson in oldMultimedia.People.ToList())
                {
                    if (!multimedia.People.Any(l => l.Id == oldPerson.Id))
                    {
                        if (oldPerson.Photo != null)
                            unitOfWork.Photos.Remove(oldPerson.Photo);

                        unitOfWork.People.Remove(oldPerson);
                    }
                }

                unitOfWork.Save();
            }
        }

        public static bool AddPerson(int multimediaId, Person person)
        {
            if (person == null)
                return false;

            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                person.MultimediaId = multimediaId;

                if (person.Photo != null)
                    unitOfWork.Photos.Add(person.Photo);

                unitOfWork.People.Add(person);

                unitOfWork.Save();
                return true;
            }
        }

        public static bool UpdatePerson(Person person)
        {
            if (person == null)
                return false;

            using (MyPhotosContainer context = new MyPhotosContainer())
            {
                IUnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(context);

                Person oldPerson = unitOfWork.People.GetById(person.Id);

                if (oldPerson == null)
                    return false;

                if (person.Photo != null)
                {
                    if (oldPerson.Photo != null)
                        PhotoFactory.Update(oldPerson.Photo, person.Photo);
                    else
                        oldPerson.Photo = PhotoFactory.Create(person.Photo);
                }

                PersonFactory.Update(oldPerson, person);

                unitOfWork.Save();
                return true;
            }
        }
    }
}
