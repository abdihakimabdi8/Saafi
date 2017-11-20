using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saafi.Core.Model;

namespace Saafi.Core.Contracts.Repository
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetAllCountries();

        Task<Country> GetCountryById(int countryId);
    }
}

