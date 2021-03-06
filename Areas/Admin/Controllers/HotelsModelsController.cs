﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SDProject03.Data;
using SDProject03.Models;

namespace SDProject03.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HotelsModelsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment iweb;


        public HotelsModelsController(ApplicationDbContext context,IWebHostEnvironment iweb)
        {
            _context = context;
            this.iweb = iweb;

        }


        [Route("/hotels/index")]
        // GET: Admin/HotelsModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.HotelsData.ToListAsync());
        }


        [Route("/hotels/details/{id}")]

        // GET: Admin/HotelsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelsModel = await _context.HotelsData
                .FirstOrDefaultAsync(m => m.HotelsId == id);
            if (hotelsModel == null)
            {
                return NotFound();
            }

            return View(hotelsModel);
        }



        [Route("/hotels/create")]
        // GET: Admin/HotelsModels/Create
        public IActionResult Create()
        {
            return View();
        }
        [Route("/hotels/create")]
        // POST: Admin/HotelsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HotelsId,HotelsName,HotelsCompanyName,HotelsTitle,HotelsDescription,HotelsMap,HotelsRating,HotelsRoomtype,HotelsSeatPrice,CheckIn,CheckoutTime,ImageFile,ImageName")] HotelsModel hotelsModel)
        {
            if (ModelState.IsValid)
            {
                //Save image to wwwroot/image
                string wwwRootPath = iweb.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(hotelsModel.ImageFile.FileName);
                string extension = Path.GetExtension(hotelsModel.ImageFile.FileName);
                hotelsModel.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/Hotels/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await hotelsModel.ImageFile.CopyToAsync(fileStream);
                }
                //Insert record
                _context.Add(hotelsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotelsModel);
        }



     
    // GET: Admin/HotelsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelsModel = await _context.HotelsData.FindAsync(id);
            if (hotelsModel == null)
            {
                return NotFound();
            }
            return View(hotelsModel);
        }

        // POST: Admin/HotelsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HotelsId,HotelsName,HotelsCompanyName,HotelsTitle,HotelsDescription,HotelsMap,HotelsRating,HotelsRoomtype,HotelsSeatPrice,CheckIn,CheckoutTime,ImageName")] HotelsModel hotelsModel)
        {
            if (id != hotelsModel.HotelsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotelsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelsModelExists(hotelsModel.HotelsId))
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
            return View(hotelsModel);
        }


        [Route("/hotels/delete/{id}")]
        // GET: Admin/HotelsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelsModel = await _context.HotelsData
                .FirstOrDefaultAsync(m => m.HotelsId == id);
            if (hotelsModel == null)
            {
                return NotFound();
            }

            return View(hotelsModel);
        }

        [Route("/hotels/delete/{id}")]
        // POST: Admin/HotelsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotelsModel = await _context.HotelsData.FindAsync(id);

            

            //delete image from wwwroot/image
            var imagePath = Path.Combine(iweb.WebRootPath, "/Image/Hotels/", hotelsModel.ImageName);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

            //delete datas from databases
            _context.HotelsData.Remove(hotelsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelsModelExists(int id)
        {
            return _context.HotelsData.Any(e => e.HotelsId == id);
        }

    }
}
