using Pubinno.Models.Entities.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pubinno.Models.Entities.Pubinno
{
    [Table("Location")]
    public class Location : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public List<TimeZone> TimeZones { get; set; }
    }
}
