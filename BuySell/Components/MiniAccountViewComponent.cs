using BuySell.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Components
{
    public class MiniAccountViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public MiniAccountViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            if (user != null)
            {
                return View(user);
            }

            return View(user);
        }
    }
}
