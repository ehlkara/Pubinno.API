using Microsoft.EntityFrameworkCore;
using Pubinno.API.Controllers;
using Pubinno.BusinessLogic.Abstract;
using Pubinno.Core.Context;
using Pubinno.Shared.PubinnoDTOs;
using Pubinno.Shared.Responses;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PubinnoTestAPI.Test
{
    public class LocationsControllerTestWithInMemoryTest : LocationsControllerTest
    {
        private readonly LocationsController _controller;

        private readonly ILocationBLL _locationBLL;

        public LocationsControllerTestWithInMemoryTest(ILocationBLL locationBLL, LocationsController controller)
        {
            SetContextOptions(new DbContextOptionsBuilder<PubinnoDbContext>().UseInMemoryDatabase("UnitTestDbInMemoryDb").Options);
            _locationBLL = locationBLL;
            _controller = controller;
        }


        [Fact]
        public async Task Create_ModelValidLocation()
        {
            var newLocation = new LocationDto { Name="Pubinno", Address = "Taksım/Istanbul", OpeningTime = DateTime.Now, ClosingTime = DateTime.UtcNow, TimeZoneName = "Etc/GMT-6" };

            _controller.ModelState.AddModelError("Name", "Required");

            var createdLocation = await _controller.AddLocation(newLocation);

            Assert.IsType<Response<LocationDto>>(createdLocation);
        }

        [Theory]
        [InlineData(1)]
        public async Task Delete_ModelValidLocation(int locationId)
        {
            var location = await _controller.DeleteLocation(locationId);

            Assert.IsType<Response<LocationDto>>(location);
        }
    }
}
