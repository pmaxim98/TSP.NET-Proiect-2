using MyPhotos.Model;
using MyPhotos.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MyPhotos.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext context;
        protected readonly DbSet<T> entities;

        public Repository(MyPhotosContainer context)
        {
            this.context = context;
            entities = this.context.Set<T>();
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return entities.Any(predicate);
        }

        public void Add(T entity)
        {
            entities.Add(entity);
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> enumerable)
        {
            entities.RemoveRange(enumerable);
        }

        public void Update(T entity)
        {
            entities.Attach(entity);
            var entry = context.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public void Update(T item, T initialEntity)
        {
            context.Entry(initialEntity).CurrentValues.SetValues(item);
        }

        public void UpdateMultimediaChildren(Multimedia updateItem, Multimedia initialEntity)
        {
            foreach (var updateLoc in updateItem.Locations)
            {
                var initialLoc = initialEntity.Locations
                    .Where(c => updateLoc.Id > 0 && c.Id == updateLoc.Id)
                    .SingleOrDefault();

                if (initialLoc != null)
                    context.Entry(initialLoc).CurrentValues.SetValues(updateLoc);
                else
                {
                    var newLoc = new Location
                    {
                        Id = updateLoc.Id,
                        MultimediaId = updateLoc.MultimediaId,
                        Multimedia = updateLoc.Multimedia,
                        Latitude = updateLoc.Latitude,
                        Longitude = updateLoc.Longitude,
                        Name = updateLoc.Name,
                        Scenery = updateLoc.Scenery,
                        ZipCode = updateLoc.ZipCode
                    };

                    initialEntity.Locations.Add(newLoc);
                }
            }

            foreach (var updatePerson in updateItem.People)
            {
                var initialPerson = initialEntity.People
                    .Where(c => updatePerson.Id > 0 && c.Id == updatePerson.Id)
                    .SingleOrDefault();

                if (initialPerson != null)
                {
                    context.Entry(initialPerson).CurrentValues.SetValues(updatePerson);

                    if (initialPerson.Photo != null)
                        context.Entry(initialPerson.Photo).CurrentValues.SetValues(updatePerson.Photo);
                    else
                    {
                        Photo newPhoto = null;

                        if (updatePerson.Photo != null)
                        {
                            newPhoto = new Photo
                            {
                                X = updatePerson.Photo.X,
                                Y = updatePerson.Photo.Y,
                                Width = updatePerson.Photo.Width,
                                Height = updatePerson.Photo.Height
                            };
                        }

                        initialPerson.Photo = newPhoto;
                    }
                }
                else
                {
                    var newPerson = new Person
                    {
                        Id = updatePerson.Id,
                        MultimediaId = updatePerson.MultimediaId,
                        Multimedia = updatePerson.Multimedia,
                        FirstName = updatePerson.FirstName,
                        LastName = updatePerson.LastName,
                        Age = updatePerson.Age,
                        Photo = updatePerson.Photo
                    };

                    initialEntity.People.Add(newPerson);
                }
            }
        }

        public IQueryable<T> Include<TEntity>(Expression<Func<T, TEntity>> predicate)
        {
            return entities.Include(predicate);
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return entities.Where(predicate);
        }

        public T GetById(int id)
        {
            return entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }
    }
}
