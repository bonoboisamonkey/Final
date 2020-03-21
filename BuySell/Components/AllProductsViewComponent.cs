using BuySell.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Components
{
    public class AllProductsViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public AllProductsViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _context.Products.Include(y=>y.Photos)
                //.Include(c=>c.Category)
                .Where(x=>x.IsDeleted==false).ToListAsync();
            return View(products);
        }
    }
}
