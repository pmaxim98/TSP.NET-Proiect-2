using MyPhotos.Model;
using MyPhotos.Repositories;
using MyPhotos.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyPhotosContainer context;

        public ILocationRepository Locations { get; }
        public IMultimediaRepository Multimedia { get; }
        public IPersonRepository People { get; }
        public IPhotoRepository Photos { get; }

        public UnitOfWork(MyPhotosContainer context)
        {
            this.context = context;

            Locations = new LocationRepository(this.context);
            Multimedia = new MultimediaRepository(this.context);
            People = new PersonRepository(this.context);
            Photos = new PhotoRepository(this.context);
        }

        public int Save()
        {
            string logPath = "Log.txt";

            if (File.Exists(logPath))
                File.Delete(logPath);

            try
            {
                return context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var error in e.EntityValidationErrors)
                {
                    File.AppendAllText(logPath, 
                        "Entity '" + error.Entry.Entity.GetType().Name + "' " +
                        "with state '" + error.Entry.State + "' contains validation errors: \n\n");

                    foreach (var validationError in error.ValidationErrors)
                    {
                        File.AppendAllText(logPath,
                            "\tProperty: '" + validationError.PropertyName + "', \n" +
                            "\tValue: '" + error.Entry.CurrentValues.GetValue<object>(validationError.PropertyName) + "' \n" +
                            "\tError: '" + validationError.ErrorMessage + "'\n\n");
                    }
                }

                throw e;
            }
            catch (Exception e)
            {
                File.WriteAllText(logPath, e.ToString());
                throw e;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
