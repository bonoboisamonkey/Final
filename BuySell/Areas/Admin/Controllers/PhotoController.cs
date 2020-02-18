using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BuySell.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhotoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhotoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Photos
                .Include(p => p.Blog)
                .Include(p => p.Product).ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .Include(p => p.Blog)
                .Include(p => p.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (photo == null)
            {
                return NotFound();
            }
            return View(photo);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeletePhoto(int? id)
        {
            var photo = await _context.Photos.FindAsync(id);

            if (photo != null)
            {
                _context.Photos.Remove(photo);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .Include(p => p.Blog)
                .Include(p => p.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (photo == null)
            {
                return NotFound();
            }
            return View(photo);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .Include(p => p.Blog)
                .Include(p => p.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (photo == null)
            {
                return NotFound();
            }
            List<SelectListItem> blogItems = new SelectList(_context.Blogs, "Id", "BlogBody").ToList();
            blogItems.Insert(0, new SelectListItem { Text = "none", Value = null });
            ViewData["BlogId"] = blogItems;

            List<SelectListItem> photoItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            photoItems.Insert(0, new SelectListItem { Text = "none", Value = null });
            ViewData["ProductId"] = photoItems;
            return View(photo);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Photo model)
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
                    if (!PhotoExists(id))
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

            List<SelectListItem> blogItems = new SelectList(_context.Blogs, "Id", "BlogBody").ToList();
            blogItems.Insert(0, new SelectListItem { Text = "none", Value = null });
            ViewData["BlogId"] = blogItems;

            List<SelectListItem> photoItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            photoItems.Insert(0, new SelectListItem { Text = "none", Value = null });
            ViewData["ProductId"] = photoItems;
            return View(model);
        }

        private bool PhotoExists(int id)
        {
            return _context.Photos.Any(e => e.Id == id);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> blogItems = new SelectList(_context.Blogs, "Id", "BlogBody").ToList();
            blogItems.Insert(0, new SelectListItem { Text = "none", Value = null });
            ViewData["BlogId"] = blogItems;

            List<SelectListItem> photoItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            photoItems.Insert(0, new SelectListItem { Text = "none", Value = null });
            ViewData["ProductId"] = photoItems;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Photo model)
        {
            if (ModelState.IsValid)
            {
                _context.Photos.Add(model);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            List<SelectListItem> blogItems = new SelectList(_context.Blogs, "Id", "BlogBody").ToList();
            blogItems.Insert(0, new SelectListItem { Text = "none", Value = null });
            ViewData["BlogId"] = blogItems;

            List<SelectListItem> photoItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            photoItems.Insert(0, new SelectListItem { Text = "none", Value = null });
            ViewData["ProductId"] = photoItems;
            return View(model);
        }
    }
}