using Pubinno.Core.Helpers;
using Pubinno.Models.Entities.Pubinno;
using Pubinno.Shared.PubinnoDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pubinno.BusinessLogic.Abstract
{
    public interface ILocationBLL
    {
        Task<LocationDto> AddLocationAsync(LocationDto locationDto);
        Task<LocationDto> UpdateLocationAsync(LocationDto locationDto);
        Task<bool> DeleteLocationAsync(int locationId);
        Task<PagedList<LocationDto>> GetLocations(LocationParameters locationParameters);
        Task<LocationDto> GetLocationByIdAsync(int locationId);
    }
}
