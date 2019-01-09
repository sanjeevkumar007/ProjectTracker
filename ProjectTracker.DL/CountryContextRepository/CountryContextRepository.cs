using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Models.Entities;
using System.Data.Entity;

namespace ProjectTracker.DL.CountryContextRepository
{
    public class CountryContextRepository : ICountryContext
    {
        private readonly ProjectContext _context;
        public CountryContextRepository()
        {
            _context = ProjectContext.GetInstance;
        }
        public async Task AddCountryAsync(Country countryToAdd)
        {
            _context.Countries.Add(countryToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Country>> GetAsync()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country> GetByIdAsync(int Id)
        {
            return await _context.Countries.FindAsync(Id);
        }

        public async Task RemoveCountryAsync(int Id)
        {
            _context.Countries.Remove(await _context.Countries.FindAsync(Id));
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCountryAsync(int Id, Country countryToUpdate)
        {
            Country country=_context.Countries.Remove(await _context.Countries.FindAsync(Id));

            country.CountryName = countryToUpdate.CountryName;
            country.CountryId = countryToUpdate.CountryId;
            country.ContinentId= countryToUpdate.ContinentId;
            country.Manager = countryToUpdate.Manager;
            country.CreatedDate = countryToUpdate.CreatedDate;

            await _context.SaveChangesAsync();
        }
    }
}
