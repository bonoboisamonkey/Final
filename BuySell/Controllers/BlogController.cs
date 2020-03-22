using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuySell.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var blogs = await _context.Blogs
                                .Include(y=>y.Photos)
                                    .Include(t => t.Comments)
                                        .Where(x=>x.IsDeleted==false).ToListAsync();
            return View(blogs);
        }

        public async Task<IActionResult> BlogPost(int id)
        {
            var blog = await _context.Blogs
                                .Include(y => y.Photos)
                                    .Include(t=>t.Comments)
                                        .Where(x => x.Id==id).FirstOrDefaultAsync();
            return View(blog);
        }
    }
}