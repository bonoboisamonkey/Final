﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BuySell.Models;
using BuySell.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BuySell.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhotoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;

        public PhotoController(ApplicationDbContext context
                                , IWebHostEnvironment environment)
        {
            _context = context;
            hostingEnvironment = environment;
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
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos.FindAsync(id);

            if (photo == null)
            {
                return NotFound();
            }
            if (!photo.IsDeleted)
            {
                photo.IsDeleted = true;
                photo.DeletedDate = DateTime.Now;
                _context.Attach(photo).State = EntityState.Modified;
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
            blogItems.Insert(0, new SelectListItem { Text = "none", Value = "0" });
            ViewData["BlogId"] = blogItems;

            List<SelectListItem> photoItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            photoItems.Insert(0, new SelectListItem { Text = "none", Value = "0" });
            ViewData["ProductId"] = photoItems;
            return View(photo);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Photo model)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var photo = await _context.Photos.FindAsync(id);

                if (photo == null)
                {
                    return NotFound();
                }

                try
                {
                    if (model.BlogId == 0 && model.ProductId == 0)
                    {
                        throw new Exception("Wrong data");
                    }
                    else
                    {
                        if (model.BlogId == 0)
                        {
                            photo.BlogId = null;
                        }
                        else if (model.ProductId == 0)
                        {
                            photo.ProductId = null;
                        }

                        photo.PhotoPath = model.PhotoPath;
                        photo.IsDeleted = model.IsDeleted;

                        if (!model.IsDeleted)
                        {
                            photo.DeletedDate = null;
                        }
                        else
                        {
                            if (photo.DeletedDate == null)
                            {
                                photo.DeletedDate = DateTime.Now;
                            }
                        }
                        photo.ModifiedDate = DateTime.Now;
                        _context.Attach(photo).State = EntityState.Modified;
                    }

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }

                return RedirectToAction(nameof(Index));

            }

            List<SelectListItem> blogItems = new SelectList(_context.Blogs, "Id", "BlogBody").ToList();
            blogItems.Insert(0, new SelectListItem { Text = "none", Value = "0" });
            ViewData["BlogId"] = blogItems;

            List<SelectListItem> photoItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            photoItems.Insert(0, new SelectListItem { Text = "none", Value = "0" });
            ViewData["ProductId"] = photoItems;
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> blogItems = new SelectList(_context.Blogs, "Id", "BlogTitle").ToList();
            blogItems.Insert(0, new SelectListItem { Text = "none", Value = "0" });
            ViewData["BlogId"] = blogItems;

            List<SelectListItem> photoItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            photoItems.Insert(0, new SelectListItem { Text = "none", Value = "0" });
            ViewData["ProductId"] = photoItems;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PhotoViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.BlogId == 0)
                {
                    model.BlogId = null;
                }
                else if (model.ProductId == 0)
                {
                    model.ProductId = null;
                }
                if (model.PhotoPath != null)
                {
                    string allowedTypes = "image/png|image/jpeg|image/gif|image/jpg";
                    if (!allowedTypes.Split('|').Contains(model.PhotoPath.ContentType))
                    {
                        throw new Exception("File type is not acceptable");
                    }
                    else
                    {
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoPath.FileName;
                        var uploads = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        var filePath = Path.Combine(uploads, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            model.PhotoPath.CopyTo(fileStream);
                        }

                        _context.Photos.Add(new Photo()
                        {
                            PhotoPath = "images/" + uniqueFileName,
                            ProductId = model.ProductId,
                            BlogId = model.BlogId,
                            AddedDate = DateTime.Now
                        });

                    }
                }
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            List<SelectListItem> blogItems = new SelectList(_context.Blogs, "Id", "BlogTitle").ToList();
            blogItems.Insert(0, new SelectListItem { Text = "none", Value = "0" });
            ViewData["BlogId"] = blogItems;

            List<SelectListItem> photoItems = new SelectList(_context.Products, "Id", "ProductName").ToList();
            photoItems.Insert(0, new SelectListItem { Text = "none", Value = "0" });
            ViewData["ProductId"] = photoItems;
            return View(model);
        }
    }
}