using ProjectTracker.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DL.CountryContextRepository
{
    public interface ICountryContext
    {
        Task<IEnumerable<Country>> GetAsync();
        Task<Country> GetByIdAsync(int Id);
        Task AddCountryAsync(Country countryToAdd);
        Task UpdateCountryAsync(int Id, Country countryToUpdate);
        Task RemoveCountryAsync(int Id);
    }
}
