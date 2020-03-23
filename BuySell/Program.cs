using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BuySell
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scopedService = host.Services.CreateScope())
            {
                var roleManager = scopedService.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();
                var userManager = scopedService.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                if (!roleManager.Roles.Any())
                {
                    var admin = new IdentityRole<int>
                    {
                        Name = "Admin"
                    };
                    roleManager.CreateAsync(admin).GetAwaiter().GetResult();

                    var moderator = new IdentityRole<int>
                    {
                        Name = "Moderator"
                    };
                    roleManager.CreateAsync(moderator).GetAwaiter().GetResult();

                    var role_user = new IdentityRole<int>
                    {
                        Name = "User"
                    };
                    roleManager.CreateAsync(role_user).GetAwaiter().GetResult();
                }

                if (!userManager.Users.Any())
                {
                    var admin = new AppUser()
                    {
                        UserName = "Admin",
                        UserSurname = "Admin",
                        Password = "Admin@1234",
                        ConfirmPassword = "Admin@1234",
                        Email = "admin@shop.az",
                        City = "Baku",
                        PostalCode = "AZ1133",
                        LockoutEnabled = false,
                        RegistredDate = DateTime.Now
                    };
                    IdentityResult result = userManager.CreateAsync(admin, admin.Password).GetAwaiter().GetResult();
                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(admin, "Admin").GetAwaiter().GetResult();
                    }
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
