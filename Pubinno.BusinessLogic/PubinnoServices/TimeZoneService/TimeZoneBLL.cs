using Abp.UI;
using AutoMapper;
using Pubinno.BusinessLogic.Abstract;
using Pubinno.DataAccess.Abstract;
using Pubinno.Models.Errors;
using Pubinno.Shared.PubinnoDTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pubinno.BusinessLogic.PubinnoServices.TimeZoneService
{
    public class TimeZoneBLL : ITimeZoneBLL
    {
        private readonly ITimeZoneDAL _timeZoneDAL;

        private readonly IMapper _mapper;

        public TimeZoneBLL(ITimeZoneDAL timeZoneDAL, IMapper mapper)
        {
            _timeZoneDAL = timeZoneDAL;
            _mapper = mapper;
        }

        public async Task<List<TimeZoneNamesDto>> GetTimeZoneNames()
        {
            try
            {
                var zones = await _timeZoneDAL.GetTimeZoneNamesAsync();
                return _mapper.Map<List<TimeZoneNamesDto>>(zones);
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException((int)ErrorCodes.TimeZoneNamesNotFound, ErrorMessages.TimeZoneNamesNotFound, ex.Message);
            }
        }
    }
}
