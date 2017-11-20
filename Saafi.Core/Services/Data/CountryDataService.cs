using System.Collections.Generic;
using System.Threading.Tasks;
using Saafi.Core.Contracts.Repository;
using Saafi.Core.Contracts.Services;
using Saafi.Core.Model;

namespace Saafi.Core.Services.Data
{
    public class CountryDataService : ICountryDataService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryDataService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public virtual async Task<List<Country>> GetAllCountries()
        {
            return await _countryRepository.GetAllCountries();
        }

        public async Task<Country> GetCountryById(int countryId)
        {
            return await _countryRepository.GetCountryById(countryId);
        }
    }
}