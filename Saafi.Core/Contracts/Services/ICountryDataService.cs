using Saafi.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saafi.Core.Contracts.Services
{
    public interface ICountryDataService
    {
        Task<List<Country>> GetAllCountries();

        Task<Country> GetCountryById(int countryId);
    }
}
