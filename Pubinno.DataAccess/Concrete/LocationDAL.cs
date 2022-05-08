using Microsoft.EntityFrameworkCore;
using Pubinno.Core.Context;
using Pubinno.Core.Helpers;
using Pubinno.DataAccess.Abstract;
using Pubinno.Models.Entities.Pubinno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeZoneConverter;

namespace Pubinno.DataAccess.Concrete
{
    public class LocationDAL : ILocationDAL
    {
        private readonly PubinnoDbContext _context;

        public LocationDAL(PubinnoDbContext context)
        {
            _context = context;
        }

        public async Task<Location> AddLocationAsync(Location location)
        {
            var zoneList = TZConvert.KnownIanaTimeZoneNames;

            Location zone = new Location
            {
                TimeZones = (List<Models.Entities.Pubinno.TimeZone>)zoneList,
            };

            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
            return location;
        }

        public async Task<bool> DeleteLocationAsync(Location location)
        {
            var locationResult = await _context.Locations.FindAsync(location.Id);

            locationResult.IsDelete = location.IsDelete = true;
            locationResult.DeletedTime = locationResult.DeletedTime = DateTime.Now;

            _context.Locations.Update(location);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Location> GetLocationByIdAsync(int locationId)
        {
            var location = await _context.Locations.FirstOrDefaultAsync(x => x.Id == locationId && x.IsDelete != true);
            return location;
        }

        public async Task<PagedList<Location>> GetLocations(LocationParameters locationParameters)
        {
            var locations = await _context.Locations.ToListAsync();
            return PagedList<Location>.ToPagedList((IQueryable<Location>)locations, locationParameters.PageNumber, locationParameters.PageSize);
        }

        public async Task<Location> UpdateLocationAsync(Location location)
        {
            var locationResult = await GetLocationByIdAsync(location.Id);

            locationResult.Name = location.Name;
            locationResult.Address = location.Address;
            locationResult.OpeningTime = location.OpeningTime;
            locationResult.ClosingTime = location.ClosingTime;
            locationResult.TimeZones = location.TimeZones;
            locationResult.IsActive = location.IsActive = true;
            locationResult.IsDelete = location.IsDelete == false;
            locationResult.UpdatedTime = location.UpdatedTime = DateTime.Now;

            _context.Locations.Update(locationResult);
            await _context.SaveChangesAsync();
            return locationResult;
        }
    }
}
