using Pubinno.Shared.PubinnoDTOs.CoreDto;
using System;
using System.Collections.Generic;

namespace Pubinno.Shared.PubinnoDTOs
{
    public class LocationDto : BaseDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public List<TimeZone> TimeZones { get; set; }
    }
}
