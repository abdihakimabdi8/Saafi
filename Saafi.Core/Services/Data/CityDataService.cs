using System.Collections.Generic;
using System.Threading.Tasks;
using Saafi.Core.Contracts.Repository;
using Saafi.Core.Contracts.Services;
using Saafi.Core.Model;

namespace Saafi.Core.Services.Data
{
    public class CityDataService : ICityDataService
    {
        private readonly ICityRepository _cityRepository;
        public CityDataService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public virtual async Task<List<City>> GetAllCities()
        {
            return await _cityRepository.GetAllCities();
        }

        public async Task<City> GetCityById(int cityId)
        {
            return await _cityRepository.GetCityById(cityId);
        }
    }
}