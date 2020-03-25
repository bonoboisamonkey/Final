using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using BuySell.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuySell.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _user;

        public CartController(ApplicationDbContext context
                                , UserManager<AppUser> user)
        {
            _context = context;
            _user = user;
        }
        public async Task<IActionResult> Add(int id)
        {

            var product = await _context.Products
                                    .Include(x => x.Photos)
                                        .Where(x => x.IsDeleted == false && x.Id == id)
                                            .FirstOrDefaultAsync();
            if (product == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var currentUser = await _user.GetUserAsync(HttpContext.User);

            if (currentUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            Cart cart = new Cart { CostumerId = currentUser.Id, ProductId = product.Id };

            var finded = await _context.Carts.Where(x => x.ProductId == cart.CostumerId && x.ProductId == product.Id).FirstOrDefaultAsync();


            if (finded == null)
            {
                await _context.Carts.AddAsync(cart);
                await _context.SaveChangesAsync();
                return View(product);
            }


            return View(null);
        }


        public async Task<IActionResult> Remove(int id)
        {
            var currentUser = await _user.GetUserAsync(HttpContext.User);

            Cart cart = new Cart { CostumerId = currentUser.Id, ProductId = id };

            var finded = await _context.Carts.Where(x => x.CostumerId == cart.CostumerId && x.ProductId == id).FirstOrDefaultAsync();


            if (!finded.isDeleted && finded != null)
            {
                finded.isDeleted = true;
                _context.Attach(finded).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return View();
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _user.GetUserAsync(HttpContext.User);

            Cart cart = new Cart { CostumerId = currentUser.Id, isDeleted = false };

            var finded = await _context.Carts.Where(x => x.CostumerId == currentUser.Id && x.isDeleted == false).ToListAsync();


            var products = new List<Product>();

            foreach (var item in finded)
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                products.Add(product);
            }

            return View(products);
        }

    }
}