using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pubinno.BusinessLogic.Abstract;
using Pubinno.Shared.PubinnoDTOs;
using Pubinno.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pubinno.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeZonesController : ControllerBase
    {
        private readonly ITimeZoneBLL _timeZoneBLL;
        private readonly ILogger<TimeZonesController> _logger;

        public TimeZonesController(ITimeZoneBLL timeZoneBLL, ILogger<TimeZonesController> logger)
        {
            _timeZoneBLL = timeZoneBLL;
            _logger = logger;
        }


        [HttpGet("get_timeZones")]
        public async Task<Response<List<TimeZoneNamesDto>>> GetTimeZoneNames()
        {
            try
            {
                var responseDto = await _timeZoneBLL.GetTimeZoneNames();
                return await Response<List<TimeZoneNamesDto>>.Run(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return await Response<List<TimeZoneNamesDto>>.Catch(new ResponseError { Messages = ex.Message });
            }

        }

    }
}
