using MyPhotos.DTO;
using MyPhotos.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace MyPhotosObjectWCF
{
    [ServiceContract]
    public interface ILocation
    {
        [OperationContract]
        LocationDTO GetLocationById(int id);

        [OperationContract]
        bool AddLocation(int multimediaId, LocationDTO locationDTO);

        [OperationContract]
        bool UpdateLocation(LocationDTO locationDTO);

        [OperationContract]
        void RemoveLocations(MultimediaDTO multimediaDTO);
    }

    [ServiceContract]
    public interface IPerson
    {
        [OperationContract]
        void RemovePeople(MultimediaDTO multimediaDTO);

        [OperationContract]
        bool AddPerson(int multimediaId, PersonDTO personDTO);

        [OperationContract]
        bool UpdatePerson(PersonDTO personDTO);
    }

    [ServiceContract]
    public interface IMultimedia
    {
        [OperationContract]
        void AddMultimedia(MultimediaDTO multimediaDTO);

        [OperationContract]
        MultimediaDTO GetMultimediaById(int id);

        [OperationContract]
        List<MultimediaDTO> GetEveryMultimedia();

        [OperationContract]
        MultimediaDTO UpdateMultimedia(MultimediaDTO multimediaDTO);

        [OperationContract]
        void FlagMultimediaAsDeleted(int id);

        [OperationContract]
        void UpdateWholeMultimedia(MultimediaDTO multimediaDTO);
    }

    [ServiceContract]
    public interface IMyPhotosService : ILocation, IPerson, IMultimedia
    {
    }
}
