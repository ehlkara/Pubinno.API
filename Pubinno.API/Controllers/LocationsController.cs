using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Pubinno.BusinessLogic.Abstract;
using Pubinno.Core.Helpers;
using Pubinno.Models.Entities.Pubinno;
using Pubinno.Shared.PubinnoDTOs;
using Pubinno.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pubinno.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationBLL _locationBLL;
        private readonly ILogger<LocationsController> _logger;

        public LocationsController(ILocationBLL locationBLL, ILogger<LocationsController> logger)
        {
            _locationBLL = locationBLL;
            _logger = logger;
        }

        [HttpGet("get_location_by_id")]
        public async Task<Response<LocationDto>> GetLocationById([FromBody] int locationId)
        {
            try
            {
                var responseDto = await _locationBLL.GetLocationByIdAsync(locationId);
                return await Response<LocationDto>.Run(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return await Response<LocationDto>.Catch(new ResponseError { Messages = ex.Message });
            }
        }

        [HttpGet("get_locations")]
        public async Task<Response<PagedList<LocationDto>>> GetLocations([FromQuery] LocationParameters locationParameters)
        {
            try
            {
                var responseDto = await _locationBLL.GetLocations(locationParameters);

                var locationdata = new
                {
                    responseDto.TotalCount,
                    responseDto.PageSize,
                    responseDto.CurrentPage,
                    responseDto.HasNext,
                    responseDto.HasPrevious
                };

                Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(locationdata));

                _logger.LogInformation($"Returned {responseDto.TotalCount} location from database");

                return await Response<PagedList<LocationDto>>.Run(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return await Response<PagedList<LocationDto>>.Catch(new ResponseError { Messages = ex.Message });
            }
        }

        [HttpPost("add_location")]
        public async Task<Response<LocationDto>> AddLocation([FromBody] LocationDto locationDto)
        {
            try
            {
                var responseDto = await _locationBLL.AddLocationAsync(locationDto);
                return await Response<LocationDto>.Run(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return await Response<LocationDto>.Catch(new ResponseError { Messages = ex.Message });
            }
        }

        [HttpPost("update_location")]
        public async Task<Response<LocationDto>> UpdateLocation([FromBody] LocationDto locationDto)
        {
            try
            {
                var responseDto = await _locationBLL.UpdateLocationAsync(locationDto);
                return await Response<LocationDto>.Run(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return await Response<LocationDto>.Catch(new ResponseError { Messages = ex.Message });
            }
        }
        [HttpDelete("delete_location")]
        public async Task<Response<bool>> DeleteLocation([FromBody] int locationId)
        {
            try
            {
                var responseDto = await _locationBLL.DeleteLocationAsync(locationId);
                return await Response<bool>.Run(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return await Response<bool>.Catch(new ResponseError { Messages = ex.Message });
            }
        }
    }
}
