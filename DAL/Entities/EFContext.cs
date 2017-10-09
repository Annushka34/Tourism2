using AdminWebSite.DAL.Entities;
using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EFContext: DbContext,IEFContext
    {
        public EFContext():base("TourConnection")
        {
            Database.SetInitializer<EFContext>(null);
        }
        public EFContext(string connectString) : base("TourConnection")
        {
            Database.SetInitializer<EFContext>(new DbInitializer());
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        public IDbSet<TEntity> Set<TEntity>() where TEntity: class
        {
            return base.Set<TEntity>();
        }
    }
}
