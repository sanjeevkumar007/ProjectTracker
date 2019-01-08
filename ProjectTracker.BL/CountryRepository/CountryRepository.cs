using ProjectTracker.DL.CountryContextRepository;
using ProjectTracker.DL.DBContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Models.Entities;

namespace ProjectTracker.BL.CountryRepository
{
    public class CountryRepository : ICountryContext
    {
        private readonly ICountryContext _context;
        public CountryRepository(ICountryContext context)
        {
            _context = context;
        }

        public async Task AddCountryAsync(Country countryToAdd)
        {
            await _context.AddCountryAsync(countryToAdd);
        }

        public async Task<IEnumerable<Country>> GetAsync()
        {
            return await _context.GetAsync();
        }

        public async Task<Country> GetByIdAsync(int Id)
        {
            return await _context.GetByIdAsync(Id);
        }

        public async Task RemoveCountryAsync(int Id)
        {
            await _context.RemoveCountryAsync(Id);
        }

        public async Task UpdateCountryAsync(int Id, Country countryToUpdate)
        {
            await _context.UpdateCountryAsync(Id, countryToUpdate);
        }
    }
}
