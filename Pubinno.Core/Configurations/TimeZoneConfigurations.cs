using Google.Apis.Compute.v1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pubinno.Models.Entities.Pubinno;
using System;
using System.Collections.Generic;
using System.Linq;
using TimeZoneConverter;

namespace Pubinno.Core.Configurations
{
    public class TimeZoneConfigurations : IEntityTypeConfiguration<TimeZoneName>
    {
        private List<string> zoneList = new List<string>();

        private List<TimeZoneName> zoneNameList = new List<TimeZoneName>();
        public void GetZoneList()
        {
           
            var list = TZConvert.KnownIanaTimeZoneNames;

            zoneList = list.ToList();

            for (int i = 1; i < zoneList.Count; i++)
            {
                zoneNameList.Add(new TimeZoneName { Id = i, ZoneName = zoneList[i], CreatedTime = DateTime.Now });
            }
        }

        public void Configure(EntityTypeBuilder<TimeZoneName> builder)
        {
            GetZoneList();

            builder.ToTable("TimeZoneName");

            //for (int i = 0; i < zoneList.Count; i++)
            //{
            //    builder.HasData(
            //        new TimeZoneName { Id = i, ZoneName = zoneList[i].ToString() }
            //        );
            //}

            builder.HasData(zoneNameList);

            //builder.HasData(

            //    for (int i = 0; i<zoneList.Count; i++)
            //{
            //    new TimeZoneName { Id = i, ZoneName = zoneList[i].ToString() };
            //}

            //new TimeZoneName{ Id = 1, ZoneName = "(GMT+00:00)"},
            //new TimeZoneName { Id = 2, ZoneName = "(GMT-12:00) International Date Line West" },
            //new TimeZoneName { Id = 3, ZoneName = "(GMT-11:00) Coordinated Universal Time-11" },
            //new TimeZoneName { Id = 4, ZoneName = "(GMT-11:00) Samoa" },
            //new TimeZoneName { Id = 5, ZoneName = "(GMT-10:00) Hawaii" },
            //new TimeZoneName { Id = 6, ZoneName = "(GMT-09:30) Marquesas Islands" },
            //new TimeZoneName { Id = 7, ZoneName = "(GMT-09:00) Alaska" },
            //new TimeZoneName { Id = 8, ZoneName = "(GMT-08:00) Baja California" },
            //new TimeZoneName { Id = 9, ZoneName = "(GMT-08:00) Pacific Time (US & Canada)" },
            //new TimeZoneName { Id = 10, ZoneName = "(GMT-07:00) Chihuahua,Mazatlan" },
            //new TimeZoneName { Id = 11, ZoneName = "(GMT-07:00) Arizona" },
            //new TimeZoneName { Id = 12, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 13, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 14, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 15, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 16, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 17, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 18, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 19, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 20, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 21, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 22, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 23, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 24, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 25, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 26, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 27, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 28, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 29, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 30, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 31, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 32, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 33, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 34, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 35, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 36, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 37, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 38, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 39, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 40, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 41, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 42, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 43, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 44, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 45, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 46, ZoneName = "(GMT+00:00)" },
            //new TimeZoneName { Id = 47, ZoneName = "(GMT+00:00)" }
        }
    }
}
