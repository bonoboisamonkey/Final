using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BuySell.Controllers
{
    //[Authorize]
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}