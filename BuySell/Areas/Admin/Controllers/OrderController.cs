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
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders
                .Include(o => o.Customer).ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer).FirstOrDefaultAsync(m => m.Id == id);

            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteOrder(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }
            if (!order.IsCanceled)
            {
                order.CancelationDate = DateTime.Now;
                order.IsCanceled = true;
            }
            _context.Attach(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer).FirstOrDefaultAsync(m => m.Id == id);

            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer).FirstOrDefaultAsync(m => m.Id == id);

            if (order == null)
            {
                return NotFound();
            }
            //ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "UserName");
            return View(order);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Order model)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var order = await _context.Orders.FindAsync(id);

                if (order == null)
                {
                    return NotFound();
                }
                try
                {
                    order.TrackingNumber = model.TrackingNumber;
                    order.OrderDate = model.OrderDate;
                    order.OrderTotalPrice = model.OrderTotalPrice;
                    order.IsCanceled = model.IsCanceled;

                    if (!model.IsCanceled)
                    {
                        order.CancelationDate = null;
                    }
                    else
                    {
                        if (order.CancelationDate == null)
                        {
                            order.CancelationDate = DateTime.Now;
                        }
                    }
                    _context.Attach(order).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }

                return RedirectToAction(nameof(Index));
            }

            //ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "UserName");
            return View(model);
        }
    }
}