using ProjectTracker.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.BL.CountryRepository
{
    public interface ICountry
    {
        Task<IEnumerable<Country>> GetCountriesAsync();
        Task<Country> GetCountryByIdAsync(int Id);
        Task AddCountryAsync(Country countryToAdd);
        Task UpdateCountryAsync(int Id, Country countryToUpdate);
        Task RemoveCountryAsync(int Id);
    }
}
