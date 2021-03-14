using System;
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
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment iweb;

        public LocationsController(ApplicationDbContext context, IWebHostEnvironment iweb)
        {
            _context = context;
            this.iweb = iweb;
        }

        [Route("/location/index")]
        // GET: Admin/Locations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Location.ToListAsync());
        }

        [Route("/location/details/{id}")]

        // GET: Admin/Locations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationsModel = await _context.Location
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (locationsModel == null)
            {
                return NotFound();
            }

            return View(locationsModel);
        }


        [Route("/location/create")]

        // GET: Admin/Locations/Create
        public IActionResult Create()
        {
            return View();
        }

        [Route("/location/create")]

        // POST: Admin/Locations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationId,LocationName,LocationTitle,LocationDescription,LocationMap,ImageFile,LocationRating")] LocationsModel locationsModel)
        {
            if (ModelState.IsValid)
            {
                //Save image to wwwroot/image
                string wwwRootPath = iweb.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(locationsModel.ImageFile.FileName);
                string extension = Path.GetExtension(locationsModel.ImageFile.FileName);
                locationsModel.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await locationsModel.ImageFile.CopyToAsync(fileStream);
                }
                //Insert record
                _context.Add(locationsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locationsModel);
        }

        // GET: Admin/Locations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationsModel = await _context.Location.FindAsync(id);
            if (locationsModel == null)
            {
                return NotFound();
            }
            return View(locationsModel);
        }

        // POST: Admin/Locations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocationId,LocationName,LocationTitle,LocationDescription,LocationMap,ImageFile,LocationRating")] LocationsModel locationsModel)
        {
            if (id != locationsModel.LocationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locationsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationsModelExists(locationsModel.LocationId))
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
            return View(locationsModel);
        }

        [Route("/location/delete/{id}")]

        // GET: Admin/Locations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationsModel = await _context.Location
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (locationsModel == null)
            {
                return NotFound();
            }

            return View(locationsModel);
        }


        [Route("/location/delete/{id}")]

        // POST: Admin/Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {



            var imageModel = await _context.Location.FindAsync(id);

            //delete image from wwwroot/image
            var imagePath = Path.Combine(iweb.WebRootPath, "/Image/", imageModel.ImageName);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            //delete the record
            _context.Location.Remove(imageModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    
        private bool LocationsModelExists(int id)
        {
            return _context.Location.Any(e => e.LocationId == id);
        }
    }
}
