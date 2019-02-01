using ProjectTracker.BL.CountryRepository;
using ProjectTracker.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProjectTracker.UI.Controllers
{
    public class CountriesController : BaseController
    {
        private readonly ICountry _context;
        public CountriesController(ICountry context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCountriesAsync()
        {
            var countries = await _context.GetCountriesAsync();
            
            return Ok(countries);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCountryByIdAsync(int Id)
        {
            if (Id==0)
            {
                return NotFound();
            }
            var country = await _context.GetCountryByIdAsync(Id);

            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        [HttpPost]
        public async Task<IHttpActionResult> AddCountryAsync(Country countryToAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.AddCountryAsync(countryToAdd);
            return Ok();
        }

        [HttpPut]
        public async Task<IHttpActionResult> UpdateCountryAsync(int Id, Country countryToUpdate)
        {
            if (Id == 0)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.UpdateCountryAsync(Id, countryToUpdate);
            return Ok();
        }

        [HttpDelete]
        public async Task<IHttpActionResult> RemoveCountryAsync(int Id)
        {
            if (Id == 0)
            {
                return NotFound();
            }

            await _context.RemoveCountryAsync(Id);
            return Ok();
        }
    }
}
