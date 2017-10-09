using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminWebSite.DAL.Entities;

namespace DAL.Concrete
{
    public class CountryRepository : ICountryRepository
    {
        private readonly IEFContext _context;
        public CountryRepository(IEFContext context)
        {
            _context = context;
        }
        public Country Add(Country country)
        {
            _context.Set<Country>().Add(country);
            return country;
        }

        public void Dispose()
        {
            if (this._context != null)
                this._context.Dispose();//для using
        }

        public IQueryable<Country> GetAllCountries()
        {
            return this._context.Set<Country>();
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }
    }
}
