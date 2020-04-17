using MyPhotos.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ILocationRepository Locations { get; }
        IMultimediaRepository Multimedia { get; }
        IPersonRepository People { get; }
        IPhotoRepository Photos { get; }

        int Save();
    }
}
