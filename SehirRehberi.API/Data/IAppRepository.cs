using SehirRehberi.API.Models;
using System.Collections.Generic;

namespace SehirRehberi.API.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        bool SaveAll();
        void Delete<T>(T entity) where T : class;

        List<City> GetCities();
        List<Photo> GetPhotosByCity(int cityId);
        City GetCityById(int cityId);
        Photo GetPhoto(int photoId);

    }
}
