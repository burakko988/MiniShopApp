using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiniShopApp.Data.Concrete.EfCore;
using MiniShopApp.WebUI.Identity;

namespace MiniShopApp.WebUI.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var applicationContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    try
                    {
                        applicationContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {

                        throw;
                    };
                }
                
            }
            using (var scope = host.Services.CreateScope())
            {
                using (var miniShopContext = scope.ServiceProvider.GetRequiredService<MiniShopContext>())
                {
                    try
                    {
                        miniShopContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {

                        throw;
                    };
                }

            }
            return host;
        }
    }
}
