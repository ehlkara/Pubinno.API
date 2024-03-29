﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pubinno.Core.Configurations;
using Pubinno.Models.Entities.Pubinno;
using Pubinno.Models.Entities.Pubinno.IdentityAuth;

namespace Pubinno.Core.Context
{
    public class PubinnoDbContext : IdentityDbContext<PubinnoUser, PubinnoRole, int>
    {
        public PubinnoDbContext(DbContextOptions<PubinnoDbContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Location> Locations { get; set; }

        public DbSet<TimeZoneName> TimeZoneNames { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Location>();
            builder.Entity<TimeZoneName>();

            builder.ApplyConfiguration(new TimeZoneConfigurations());
        }
    }
}
