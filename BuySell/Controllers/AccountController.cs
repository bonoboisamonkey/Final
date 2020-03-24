using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace BuySell.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(SignInManager<AppUser> signInManager
                                    , UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return RedirectToAction("Login");
            }

            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.FindByEmailAsync(model.Email);
                if (currentUser != null)
                {
                    ModelState.AddModelError("", "Email is in use already");
                    return View();
                }

                AppUser user = new AppUser()
                {
                    Email = model.Email,
                    Password = model.Password,
                    PostalCode = model.PostalCode,
                    RegistredDate = model.RegistredDate,
                    UserName = model.UserName,
                    UserSurname = model.UserSurname,
                    City = model.City,
                    ConfirmPassword = model.ConfirmPassword
                };

                IdentityResult identityResult = await _userManager.CreateAsync(user, user.Password);

                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (IdentityError error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
            }
            else
                return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user != null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.FindByEmailAsync(model.Email);
                if (currentUser == null)
                {
                    ModelState.AddModelError("", "Given email is not exists");
                    return View();
                }
                else
                {
                    SignInResult signInResult = await _signInManager.
                                                        PasswordSignInAsync(currentUser, model.Password, true, true);

                    if (!signInResult.Succeeded)
                    {
                        ModelState.AddModelError("", "Wrong Password");
                        return View();
                    }
                    else
                        if (signInResult.IsLockedOut)
                    {
                        ModelState.AddModelError("", "User locked out!");
                        return View();
                    }
                    else
                    {
                        if(currentUser.Email=="admin@shop.az" && currentUser.Password == "Admin@1234")
                        {
                            return RedirectToAction("Index", "Admin", new { Area = "Admin" });
                        }
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            else
                return View();
        }

        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}