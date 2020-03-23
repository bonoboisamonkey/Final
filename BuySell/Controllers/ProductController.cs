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
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            var product = await _context.Products
                            .Include(x => x.Photos)
                                .Include(y => y.Comments)
                                    .FirstOrDefaultAsync(x => x.Id == id);

            var categoryId = await _context.Products
                                .Where(t => t.Id == id)
                                    .Select(x => x.CategoryId)
                                        .FirstOrDefaultAsync();

            var relatedProducts = await _context.Products
                                    .Include(x => x.Photos)
                                        .Where(t => t.CategoryId == categoryId).ToListAsync();

            var model = new ProductViewModel()
            {
                Product = product,
                RelatedProducts = relatedProducts
            };
            return View(model);
        }
    }
}