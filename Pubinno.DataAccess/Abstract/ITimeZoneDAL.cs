using Pubinno.Models.Entities.Pubinno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubinno.DataAccess.Abstract
{
    public interface ITimeZoneDAL
    {
        Task<List<TimeZoneName>> GetTimeZoneNamesAsync();
    }
}
