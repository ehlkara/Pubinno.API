using Microsoft.EntityFrameworkCore;
using Pubinno.Core.Context;
using Pubinno.Models.Entities.Pubinno;

namespace PubinnoTestAPI.Test
{
    public class LocationsControllerTest
    {
        protected DbContextOptions<PubinnoDbContext> _contextOptions { get; private set; }

        public void SetContextOptions(DbContextOptions<PubinnoDbContext> contextOptions)
        {
            _contextOptions = contextOptions;
            Seed();
        }

        public void Seed()
        {
            using (PubinnoDbContext context = new PubinnoDbContext(_contextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Locations.Add(new Location { });
                context.SaveChanges();
            }
        }
    }
}
