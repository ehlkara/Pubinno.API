using Pubinno.Core.Helpers;
using Pubinno.Models.Entities.Pubinno;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pubinno.DataAccess.Abstract
{
    public interface ILocationDAL
    {
        Task<Location> AddLocationAsync(Location location);
        Task<Location> UpdateLocationAsync(Location location);
        Task<bool> DeleteLocationAsync(Location location);
        Task<PagedList<Location>> GetLocations(LocationParameters locationParameters);
        Task<Location> GetLocationByIdAsync(int locationId);
    }
}
