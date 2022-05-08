using Pubinno.Shared.PubinnoDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubinno.BusinessLogic.Abstract
{
    public interface ITimeZoneBLL
    {
        Task<List<TimeZoneNamesDto>> GetTimeZoneNames();
    }
}
