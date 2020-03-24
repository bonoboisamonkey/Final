using BuySell.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Utilities
{
    public static class UserInitializer
    {
        internal static void AddUsers(IServiceScope scopedService)
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
                AppUser admin = new AppUser()
                {
                    UserName = "Admin",
                    UserSurname = "Admin",
                    Password = "Admin@1234",
                    ConfirmPassword = "Admin@1234",
                    Email = "admin@shop.az",
                    EmailConfirmed = true,
                    City = "Baku",
                    PostalCode = "AZ1133",
                    LockoutEnabled = false,
                    RegistredDate = new DateTime(2020, 01, 23, 04, 54, 31)
                };
                IdentityResult result = userManager.CreateAsync(admin, admin.Password).GetAwaiter().GetResult();
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(admin, "Admin").GetAwaiter().GetResult();
                }

                AppUser appUser = new AppUser()
                {
                    UserName = "Ali",
                    UserSurname = "Aliyev",
                    Password = "Ali@1234",
                    ConfirmPassword = "Ali@1234",
                    Email = "ali@shop.az",
                    City = "Baku",
                    PostalCode = "AZ1133",
                    PhoneNumber = "+994501234567",
                    EmailConfirmed = true,
                    RegistredDate = DateTime.Now
                };

                IdentityResult resultAppUser = userManager.CreateAsync(appUser, appUser.Password).GetAwaiter().GetResult();
                if (resultAppUser.Succeeded)
                {
                    userManager.AddToRoleAsync(appUser, "User").GetAwaiter().GetResult();
                };

                AppUser anotherUser = new AppUser()
                {
                    UserName = "Arzu",
                    UserSurname = "Babayeva",
                    Password = "Arzu@1234",
                    ConfirmPassword = "Arzu@1234",
                    Email = "arzu@shop.az",
                    City = "Baku",
                    PostalCode = "AZ1133",
                    PhoneNumber = "+994501234567",
                    EmailConfirmed = true,
                    RegistredDate = DateTime.Now
                };
                
                IdentityResult resultUser = userManager.CreateAsync(anotherUser, anotherUser.Password).GetAwaiter().GetResult();
                if (resultUser.Succeeded)
                {
                    userManager.AddToRoleAsync(anotherUser, "User").GetAwaiter().GetResult();
                };

                AppUser otherUser = new AppUser()
                {
                    UserName = "Dadash",
                    UserSurname = "Nuriyev",
                    Password = "Dadash@1234",
                    ConfirmPassword = "Dadash@1234",
                    Email = "dadash@shop.az",
                    City = "Baku",
                    PostalCode = "AZ1133",
                    PhoneNumber = "+994501234567",
                    EmailConfirmed = true,
                    RegistredDate = DateTime.Now
                };

                IdentityResult resultLast = userManager.CreateAsync(otherUser, otherUser.Password).GetAwaiter().GetResult();
                if (resultLast.Succeeded)
                {
                    userManager.AddToRoleAsync(otherUser, "User").GetAwaiter().GetResult();
                };

                AppUser appModerator = new AppUser()
                {
                    UserName = "Lala",
                    UserSurname = "Balayeva",
                    Password = "Lala@1234",
                    ConfirmPassword = "Lala@1234",
                    Email = "lala@shop.az",
                    City = "Baku",
                    PostalCode = "AZ1133",
                    PhoneNumber = "+994501234567",
                    EmailConfirmed = true,
                    RegistredDate = DateTime.Now
                };

                IdentityResult moderator = userManager.CreateAsync(appModerator, appModerator.Password).GetAwaiter().GetResult();
                if (moderator.Succeeded)
                {
                    userManager.AddToRoleAsync(appModerator, "Moderator").GetAwaiter().GetResult();
                };
            }
        }
    }
}
