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
    [Area("Admin")]
    public class CommentController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Comments.Include(c => c.Blog).Include(c => c.Product).ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.Blog)
                .Include(c => c.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteComment(int? id)
        {
            var comment = await _context.Comments.FindAsync(id);

            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

            return RedirectToPage(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.Blog)
                .Include(c => c.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.Blog)
                .Include(c => c.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (comment == null)
            {
                return NotFound();
            }
            List<SelectListItem> blogItems = new SelectList(_context.Blogs, "Id", "BlogBody").ToList();
            blogItems.Insert(0, new SelectListItem { Text = "none", Value = null });
            ViewData["BlogId"] = blogItems;

            List<SelectListItem> productItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            productItems.Insert(0, new SelectListItem { Value = null, Text = "none" });
            ViewData["ProductId"] = productItems;
            return View(comment);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Comment model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.BlogId==null && model.ProductId==null)
                    {
                        throw new Exception("wrong data");
                    }
                    else
                    {
                        _context.Update(model);
                        await _context.SaveChangesAsync();
                    }                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(id))
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

            List<SelectListItem> productItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            productItems.Insert(0, new SelectListItem { Value = null, Text = "none" });
            ViewData["ProductId"] = productItems;
            return View();
        }

        private bool CommentExists(int id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
        
    }
}