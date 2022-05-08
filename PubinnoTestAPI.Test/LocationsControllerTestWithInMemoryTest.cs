using Microsoft.EntityFrameworkCore;
using Pubinno.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PubinnoTestAPI.Test
{
    public class LocationsControllerTestWithInMemoryTest : LocationsControllerTest
    {
        public LocationsControllerTestWithInMemoryTest()
        {
            SetContextOptions(new DbContextOptionsBuilder<PubinnoDbContext>().UseInMemoryDatabase("UnitTestDbInMemoryDb").Options);
        }


        [Fact]
        public async Task Create_ModelValidLocation()
        {

        }

        [Theory]
        [InlineData(1)]
        public async Task Delete_ModelValidLocation(int locationId)
        {
            using (var context = new PubinnoDbContext(_contextOptions))
            {
                var location = await context.Locations.FindAsync(locationId);
            }
        }
    }
}
