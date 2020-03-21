using BuySell.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Components
{
    public class SliderViewComponent: ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public SliderViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slider =  await _context.Blogs.Include(x => x.Photos)
                                    .Where(y=>y.IsDeleted==false).ToListAsync();
            return View(slider);
        }
    }
}
