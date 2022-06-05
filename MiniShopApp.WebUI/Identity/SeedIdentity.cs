using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            //Admin oluşturma kodları
            var adminUserName = configuration["UserData:AdminUser:UserName"];
            var adminEmail = configuration["UserData:AdminUser:Email"];
            var adminPassword = configuration["UserData:AdminUser:Password"];
            var adminRole = configuration["UserData:AdminUser:Role"];
            if (await userManager.FindByNameAsync(adminUserName)==null)
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
                var adminUser = new User()
                {
                    UserName = adminUserName,
                    Email = adminEmail,
                    FirstName = "Admin",
                    LastName = "Admin",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, adminRole);
                }
            }

            //User oluşturma kodları
            var userUserName = configuration["UserData:CustomerUser:UserName"];
            var userEmail = configuration["UserData:CustomerUser:Email"];
            var userPassword = configuration["UserData:CustomerUser:Password"];
            var userRole = configuration["UserData:CustomerUser:Role"];
            if (await userManager.FindByNameAsync(userUserName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(userRole));
                var userUser = new User()
                {
                    UserName = userUserName,
                    Email = userEmail,
                    FirstName = "User",
                    LastName = "User",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(userUser, userPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(userUser, userRole);
                }
            }
        }
    }
}
