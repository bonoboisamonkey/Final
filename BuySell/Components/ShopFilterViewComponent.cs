using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Components
{
    public class ShopFilterViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public ShopFilterViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var brands = new Dictionary<string,int>();
            var productName = await _context.Products.Select(x => x.ProductName).ToListAsync();
            foreach (var item in productName)
            {
                string name = item.Split(" ")[0];
                if (brands.ContainsKey(name))
                {
                    int num = brands[name];
                    num++;
                    brands[name] = num;
                }
                else
                {
                    brands.Add(name, 1);
                }
            };


            var model = new ShopFilterViewModel()
            {
                Products = await _context.Products.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                Brands = brands
            };

            return View(model);
        }
    }
}
