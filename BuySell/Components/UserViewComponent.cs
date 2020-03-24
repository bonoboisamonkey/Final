using BuySell.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BuySell.Components
{
    public class UserViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public UserViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            return View(user);
        }
        
    }
}
