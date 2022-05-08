using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubinno.Core.Configurations
{
    public class TimeZoneConfigurations : IEntityTypeConfiguration<TimeZone>
    {
        public void Configure(EntityTypeBuilder<TimeZone> builder)
        {
            builder.ToTable("TimeZone");
        }
    }
}
