using Abp.UI;
using AutoMapper;
using Pubinno.BusinessLogic.Abstract;
using Pubinno.Core.Helpers;
using Pubinno.DataAccess.Abstract;
using Pubinno.Models.Entities.Pubinno;
using Pubinno.Models.Errors;
using Pubinno.Shared.PubinnoDTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pubinno.BusinessLogic.PubinnoServices.LocationService
{
    public class LocationBLL : ILocationBLL
    {
        private readonly ILocationDAL _locationDAL;

        private readonly IMapper _mapper;

        public LocationBLL(ILocationDAL locationDAL, IMapper mapper)
        {
            _locationDAL = locationDAL;
            _mapper = mapper;
        }

        public async Task<LocationDto> AddLocationAsync(LocationDto locationDto)
        {
            try
            {
                var mappedDto = _mapper.Map<Location>(locationDto);
                var locationResult = await _locationDAL.AddLocationAsync(mappedDto);
                _mapper.Map<LocationDto>(locationResult);
                return locationDto;
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException((int)ErrorCodes.LocationCannotCreate, ErrorMessages.LocationCannotCreate, ex.Message);
            }
        }

        public async Task<bool> DeleteLocationAsync(int locationId)
        {
            try
            {
                var location = await _locationDAL.GetLocationByIdAsync(locationId);
                var mappedLocation = _mapper.Map<Location>(location);
                return await _locationDAL.DeleteLocationAsync(mappedLocation);
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException((int)ErrorCodes.LocationCannotDelete, ErrorMessages.LocationCannotDelete, ex.Message);
            }
        }

        public async Task<LocationDto> GetLocationByIdAsync(int locationId)
        {
            try
            {
                var location = await _locationDAL.GetLocationByIdAsync(locationId);
                return _mapper.Map<LocationDto>(location);
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException((int)ErrorCodes.LocationNotFound, ErrorMessages.LocationNotFound, ex.Message);
            }
        }

        public async Task<PagedList<LocationDto>> GetLocations(LocationParameters locationParameters)
        {
            try
            {
                var locations = await _locationDAL.GetLocations(locationParameters);
                return _mapper.Map<PagedList<LocationDto>>(locations);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException((int)ErrorCodes.LocationsNotFound, ErrorMessages.LocationsNotFound, ex.Message);
            }
        }

        public async Task<LocationDto> UpdateLocationAsync(LocationDto locationDto)
        {
            try
            {
                var mappedLocation = _mapper.Map<Location>(locationDto);

                var locationResult = await _locationDAL.UpdateLocationAsync(mappedLocation);

                return _mapper.Map<LocationDto>(locationResult);
            }
            catch (Exception ex)
            {


                throw new UserFriendlyException((int)ErrorCodes.LocationCannotUpdate, ErrorMessages.LocationCannotUpdate, ex.Message);
            }
        }
    }
}
