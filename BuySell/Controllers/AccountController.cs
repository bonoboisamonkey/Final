using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BuySell.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        //private readonly RoleManager<IdentityUser> _roleManager;

        public AccountController(SignInManager<AppUser> signInManager
                                //,RoleManager<IdentityUser> roleManager
                                )
        {
            _signInManager = signInManager;
            //_roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Name, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "Admin");
                }

                ModelState.AddModelError(String.Empty, "You are not my Admin");
            }
            return View(model);
        }
    }
}