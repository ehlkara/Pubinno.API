using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pubinno.Models.Entities.Pubinno.IdentityAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubinno.Core.Context
{
    public class PubinnoDbContext : IdentityDbContext<PubinnoUser, PubinnoRole, int>
    {
        public PubinnoDbContext(DbContextOptions<PubinnoDbContext> dbContext) : base(dbContext)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
