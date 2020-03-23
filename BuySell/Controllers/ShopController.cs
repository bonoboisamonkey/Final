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

        [HttpGet("{id}")]
        public async Task<IActionResult> Index(int id)
        {
            List<Product> allFeatures = new List<Product>();

            var childCategories = await _context.Categories
                                            .Where(x => x.ParentId == id)
                                                .Select(x=>x.Id).ToListAsync();

            if (childCategories == null)
            {
                return NotFound();
            }

            var allParents = await _context.Categories
                                        .Where(x => x.ParentId != null)
                                            .Select(x=>x.ParentId).ToListAsync();

            if (!allParents.Contains(id))
            {
                allFeatures = await _context.Products
                                         .Include(y => y.Photos)
                                             .Where(x => x.IsDeleted == false)
                                                .Where(x=>x.CategoryId == id).ToListAsync();

                return View(allFeatures);
            }

            List<int> endNodes = new List<int>();

            foreach (var item in childCategories)
            {
                if (allParents.Contains(item))
                {
                    var grandCategories = await _context.Categories
                                                .Where(x => x.ParentId == item)
                                                    .Select(x => x.Id).ToListAsync();
                    endNodes.AddRange(grandCategories);
                }
                else
                {
                    endNodes.Add(item);
                }
            }

            foreach (var item in endNodes)
            {
                var products = await _context.Products
                                       .Include(x => x.Photos)
                                           .Where(x => x.CategoryId == item).ToListAsync();
                allFeatures.AddRange(products);
            }
           
            return View(allFeatures);
        }
    }
}