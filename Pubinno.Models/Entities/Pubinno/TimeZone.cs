using Pubinno.Models.Entities.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pubinno.Models.Entities.Pubinno
{
    [Table("TimeZone")]
    public class TimeZone : BaseEntity
    {
        public int Id { get; set; }
        public string ZoneName { get; set; }
    }
}
