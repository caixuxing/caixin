using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace CaiXin.Infrastructure.Data.SeedData
{
    public static class DatabaseExtentions
    {
        public static async Task InitialiseDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if ((await context.Database.GetPendingMigrationsAsync()).Any())
            {
                await context.Database.MigrateAsync();
            }
                 
            await SeedAsync(context);
        }

        private static async Task SeedAsync(ApplicationDbContext context)
        {
            await SeedSysUsersAsync(context);
        }

     
        private static async Task SeedSysUsersAsync(ApplicationDbContext context)
        {
            if (!await context.SysUser.AnyAsync())
            {
                await context.SysUser.AddRangeAsync(InitData.SysUsers);
                await context.SaveChangesAsync();
            }
        }

    }
}
