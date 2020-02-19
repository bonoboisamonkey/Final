using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Identity;
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
        [HttpPost]
        public async Task<IActionResult> Delete(int? id, Blog model)
        {
            var blog = await _context.Blogs.FindAsync(id);

            if (model.IsDeleted)
            {
                _context.Blogs.Update(model);
            }
            else
            {
                _context.Blogs.Update(new Blog
                {
                    BlogTitle = model.BlogTitle,
                    BlogBody = model.BlogBody,
                    IsDeleted = true,
                    AddedDate = model.AddedDate,
                    ModifiedDate = model.ModifiedDate,
                    DeletedDate = DateTime.Now,
                    AddedBy = model.AddedBy,
                    ModifiedBy = model.ModifiedBy, //--should be added role based identification
                    DeletedBy = model.DeletedBy
                });
            }
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
                    _context.Update(new Blog
                    {
                        BlogTitle = model.BlogTitle,
                        BlogBody = model.BlogBody,
                        IsDeleted = model.IsDeleted,
                        AddedDate = model.AddedDate,
                        ModifiedDate = DateTime.Now,
                        DeletedDate = model.DeletedDate,
                        AddedBy = model.AddedBy,
                        ModifiedBy = model.ModifiedBy,
                        DeletedBy = model.DeletedBy
                    });
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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Blog model)
        {
            if (ModelState.IsValid)
            {
                _context.Blogs.Add(new Blog
                {
                    BlogTitle = model.BlogTitle,
                    BlogBody = model.BlogBody,
                    AddedDate = DateTime.Now,
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

            return View();

        }
    }
}