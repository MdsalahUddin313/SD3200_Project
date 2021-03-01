using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public HotelsModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/HotelsModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.HotelsData.ToListAsync());
        }

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

        // GET: Admin/HotelsModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HotelsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HotelsId,HotelsName,HotelsCompanyName,HotelsTitle,HotelsDescription,HotelsMap,HotelsRating,HotelsRoomtype,HotelsSeatPrice,CheckIn,CheckoutTime,ImageName")] HotelsModel hotelsModel)
        {
            if (ModelState.IsValid)
            {
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

        // POST: Admin/HotelsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotelsModel = await _context.HotelsData.FindAsync(id);
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
