using BuySell.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Components
{
    public class BestRatedViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public BestRatedViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int count = _context.Products.Where(x => x.ProductRating == 5).Count();
            Random random = new Random();
            int skip = random.Next(0, count-7);
           var ratedProducts = await _context.Products
                                .Where(x => x.ProductRating == 5)
                                .Skip(skip)
                                .Take(7)
                                .ToListAsync();
            return View(ratedProducts);
        }
    }
}
