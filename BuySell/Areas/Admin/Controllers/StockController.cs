using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BuySell.Areas.Admin.Controllers
{
    public class StockController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stocks.Include(s => s.Product).ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.Stocks
                .Include(s => s.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (stock == null)
            {
                return NotFound();
            }
            return View(stock);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteStock(int? id)
        {
            var stock = await _context.Stocks.FindAsync(id);
            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.Stocks
                .Include(s => s.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (stock == null)
            {
                return NotFound();
            }
            return View(stock);
        }

        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(StockViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Stocks.Add(new Stock { 
                Count = model.Count,
                IsAvailable = model.IsAvailable,
                ProductId = model.ProductId
                });
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(model);

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock = await _context.Stocks
                .Include(s => s.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (stock == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductName");
            return View(stock);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Stock model)
        {
            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductName");
            return View(model);
        }

        private bool StockExists(int id)
        {
            return _context.Stocks.Any(e => e.Id == id);
        }
    }
}