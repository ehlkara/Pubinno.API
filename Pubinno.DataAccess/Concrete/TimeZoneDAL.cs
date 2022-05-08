using Microsoft.EntityFrameworkCore;
using Pubinno.Core.Context;
using Pubinno.DataAccess.Abstract;
using Pubinno.Models.Entities.Pubinno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubinno.DataAccess.Concrete
{
    public class TimeZoneDAL : ITimeZoneDAL
    {
        private readonly PubinnoDbContext _context;

        public TimeZoneDAL(PubinnoDbContext context)
        {
            _context = context;
        }

        public async Task<List<TimeZoneName>> GetTimeZoneNamesAsync()
        {
            var zoneList = await _context.TimeZoneNames.ToListAsync();
            return zoneList;
        }
    }
}
