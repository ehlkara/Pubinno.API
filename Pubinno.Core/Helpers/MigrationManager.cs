using Abp.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pubinno.Core.Context;
using Pubinno.Models.Errors;
using System;

namespace Pubinno.Core.Helpers
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var xpressContext = scope.ServiceProvider.GetRequiredService<PubinnoDbContext>())
                {
                    try
                    {
                        xpressContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {

                        throw new UserFriendlyException((int)ErrorCodes.NotWorkMigrate, ErrorMessages.NotWorkedMigrate, ex.Message);
                    }
                }
            }
            return host;
        }
    }
}
