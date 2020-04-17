using MyPhotos;
using MyPhotos.DTO;
using MyPhotos.Model;

using AutoMapper;

using System.Collections.Generic;

namespace MyPhotosObjectWCF
{
    public class MyPhotosService : IMyPhotosService
    {
        MapperConfiguration mapperConfiguration;
        IMapper mapper;

        public MyPhotosService()
        {
            mapperConfiguration = new MapperConfiguration
            (
                config => 
                {
                    config.CreateMap<Multimedia, MultimediaDTO>();
                    config.CreateMap<Location, LocationDTO>();
                    config.CreateMap<Person, PersonDTO>();
                    config.CreateMap<Photo, PhotoDTO>();
                    config.CreateMap<Weather, WeatherDTO>();

                    config.CreateMap<MultimediaDTO, Multimedia>();
                    config.CreateMap<LocationDTO, Location>();
                    config.CreateMap<PersonDTO, Person>();
                    config.CreateMap<PhotoDTO, Photo>();
                    config.CreateMap<WeatherDTO, Weather>();
                }
            );

            mapper = mapperConfiguration.CreateMapper();
        }

        public LocationDTO GetLocationById(int id)
        {
            Location location = API.GetLocationById(id);

            return mapper.Map<Location, LocationDTO>(location);
        }

        public bool AddLocation(int multimediaId, LocationDTO locationDTO)
        {
            Location location = mapper.Map<LocationDTO, Location>(locationDTO);

            return API.AddLocation(multimediaId, location);
        }

        public bool UpdateLocation(LocationDTO locationDTO)
        {
            Location location = mapper.Map<LocationDTO, Location>(locationDTO);

            return API.UpdateLocation(location);
        }

        public void RemoveLocations(MultimediaDTO multimediaDTO)
        {
            Multimedia multimedia = mapper.Map<MultimediaDTO, Multimedia>(multimediaDTO);

            API.RemoveLocations(multimedia);
        }

        public void RemovePeople(MultimediaDTO multimediaDTO)
        {
            Multimedia multimedia = mapper.Map<MultimediaDTO, Multimedia>(multimediaDTO);

            API.RemovePeople(multimedia);
        }

        public bool AddPerson(int multimediaId, PersonDTO personDTO)
        {
            Person person = mapper.Map<PersonDTO, Person>(personDTO);

            return API.AddPerson(multimediaId, person);
        }

        public bool UpdatePerson(PersonDTO personDTO)
        {
            Person person = mapper.Map<PersonDTO, Person>(personDTO);

            return API.UpdatePerson(person);
        }

        public void AddMultimedia(MultimediaDTO multimediaDTO)
        {
            Multimedia multimedia = mapper.Map<MultimediaDTO, Multimedia>(multimediaDTO);

            API.AddMultimedia(multimedia);
        }

        public MultimediaDTO GetMultimediaById(int id)
        {
            Multimedia multimedia = API.GetMultimediaById(id);
            
            return mapper.Map<Multimedia, MultimediaDTO>(multimedia);
        }

        public List<MultimediaDTO> GetEveryMultimedia()
        {
            List<Multimedia> multimedia = API.GetEveryMultimedia();

            return mapper.Map<List<Multimedia>, List<MultimediaDTO>>(multimedia);
        }

        public MultimediaDTO UpdateMultimedia(MultimediaDTO multimediaDTO)
        {
            Multimedia multimedia = mapper.Map<MultimediaDTO, Multimedia>(multimediaDTO);

            return mapper.Map<Multimedia, MultimediaDTO>(API.UpdateMultimedia(multimedia));
        }

        public void FlagMultimediaAsDeleted(int id)
        {
            API.FlagMultimediaAsDeleted(id);
        }

        public void UpdateWholeMultimedia(MultimediaDTO multimediaDTO)
        {
            Multimedia multimedia = mapper.Map<MultimediaDTO, Multimedia>(multimediaDTO);

            API.UpdateWholeMultimedia(multimedia);
        }
    }
}
