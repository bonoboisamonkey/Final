using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories
                 .Include(c => c.Parent)
                 .ToListAsync();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> items = new SelectList(_context.Categories, "Id", "Name").ToList();
            items.Insert(0, (new SelectListItem { Text = "None", Value = "0" }));
            ViewData["ParentId"] = items;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ParentId != 0)
                {
                    _context.Categories.Add(new Category
                    {
                        Name = model.Name,
                        ParentId = model.ParentId
                    });
                    await _context.SaveChangesAsync();
                }
                else
                {
                    _context.Categories.Add(new Category
                    {
                        Name = model.Name,
                        ParentId = null
                    });
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }

            List<SelectListItem> items = new SelectList(_context.Categories, "Id", "Name").ToList();
            items.Insert(0, (new SelectListItem { Text = "None", Value = "0" }));
            ViewData["ParentId"] = items;

            return View(model);

        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {

            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            List<SelectListItem> items = new SelectList(_context.Categories, "Id", "Name").ToList();
            items.Insert(0, (new SelectListItem { Text = "None", Value = "0" }));
            ViewData["ParentId"] = items;
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Category model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryViewModelExists(id))
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

            List<SelectListItem> items = new SelectList(_context.Categories, "Id", "Name").ToList();
            items.Insert(0, (new SelectListItem { Text = "None", Value = "0" }));
            ViewData["ParentId"] = items;
            return View(model);
        }

        private bool CategoryViewModelExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
