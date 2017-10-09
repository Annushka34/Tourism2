using System.Data.Entity;

namespace DAL.Entities
{
    internal class DbInitializer : CreateDatabaseIfNotExists<EFContext>
    {
        protected override void Seed(EFContext context)
        {
            base.Seed(context);
        }
    }
}