using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuySell.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blogs.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs.FirstOrDefaultAsync(m => m.Id == id);

            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int? id)
        {
            var blog = await _context.Blogs.FindAsync(id);

            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();

            return RedirectToPage(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs.FirstOrDefaultAsync(m => m.Id == id);

            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs.FirstOrDefaultAsync(m => m.Id == id);

            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Blog model)
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
                    if (!BlogExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToPage(nameof(Index));


            }

            return View(model);
        }

        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.Id == id);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(BlogViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Blogs.Add(new Blog
            {
                BlogTitle = model.BlogTitle,
                BlogBody = model.BlogBody,
                AddedDate = model.AddedDate,
                DeletedDate = model.DeletedDate,
                ModifiedDate = model.ModifiedDate,
                DeletedBy = model.DeletedBy,
                AddedBy = model.AddedBy,
                ModifiedBy = model.ModifiedBy
            }
            );
            await _context.SaveChangesAsync();

            return RedirectToPage(nameof(Index));
        }
    }
}