using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuySell.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allFeatures = await _context.Products
                                          .Include(y => y.Photos)
                                              .Where(x => x.IsDeleted == false).ToListAsync();
            return View(allFeatures);
        }
    }
}