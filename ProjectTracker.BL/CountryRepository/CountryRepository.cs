
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Models.Entities;
using ProjectTracker.DL;

namespace ProjectTracker.BL.CountryRepository
{
    public class CountryRepository : ICountry
    {
        private readonly IRepository<Country> _context;
        public CountryRepository(IRepository<Country> context)
        {
            _context = context;
        }

        public async Task AddCountryAsync(Country countryToAdd)
        {
            await _context.CreateAsync(countryToAdd);
        }

        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
            return await _context.GetAllAsync();
        }

        public async Task<Country> GetCountryByIdAsync(int Id)
        {
            return await _context.GetAsync(Id);
        }

        public async Task RemoveCountryAsync(int Id)
        {
            await _context.RemoveAsync(Id);
        }

        public async Task UpdateCountryAsync(int Id, Country countryToUpdate)
        {
            await _context.UpdateAsync(Id, countryToUpdate);
        }
    }
}
