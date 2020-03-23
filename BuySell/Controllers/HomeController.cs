using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BuySell.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            int count = _context.Products.Where(x => x.ProductRating == 5).Count();
            Random random = new Random();
            int skip = random.Next(0, count - 7);


            var allProducts = new HomePageViewModel()
            {
                AllProducts = await _context.Products
                                        .Include(y => y.Photos)
                                            .Where(x => x.IsDeleted == false).ToListAsync(),
                BestRatedProducts = await _context.Products
                                  .Include(p => p.Photos)
                                    .Where(x => x.ProductRating == 5)
                                        .Skip(skip)
                                            .Take(7).ToListAsync(),
                Slides = await _context.Blogs
                                .Include(x => x.Photos)
                                    .Where(y => y.IsDeleted == false).ToListAsync(),
                OnSaleProducts = await _context.Products
                                    .Include(x => x.Photos)
                                        .Where(s => s.ProductDiscount != 0).ToListAsync(),
                Categories = await _context.Categories.ToListAsync()
            };

            return View(allProducts);
        }
    }
}
