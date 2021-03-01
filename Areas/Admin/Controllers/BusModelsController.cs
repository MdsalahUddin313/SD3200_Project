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
    public class BusModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BusModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BusModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.BusData.ToListAsync());
        }

        // GET: Admin/BusModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var busModel = await _context.BusData
                .FirstOrDefaultAsync(m => m.BusId == id);
            if (busModel == null)
            {
                return NotFound();
            }

            return View(busModel);
        }

        // GET: Admin/BusModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BusModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BusId,BusName,BusCompanyName,BusTitle,BusDescription,BusMap,BusRating,BusSeatType,BusSeatPrice,DepartureTime,BusDepartureLocation,BusArrivalLocation,ArrivalTime,ImageName")] BusModel busModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(busModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(busModel);
        }

        // GET: Admin/BusModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var busModel = await _context.BusData.FindAsync(id);
            if (busModel == null)
            {
                return NotFound();
            }
            return View(busModel);
        }

        // POST: Admin/BusModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BusId,BusName,BusCompanyName,BusTitle,BusDescription,BusMap,BusRating,BusSeatType,BusSeatPrice,DepartureTime,BusDepartureLocation,BusArrivalLocation,ArrivalTime,ImageName")] BusModel busModel)
        {
            if (id != busModel.BusId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(busModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusModelExists(busModel.BusId))
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
            return View(busModel);
        }

        // GET: Admin/BusModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var busModel = await _context.BusData
                .FirstOrDefaultAsync(m => m.BusId == id);
            if (busModel == null)
            {
                return NotFound();
            }

            return View(busModel);
        }

        // POST: Admin/BusModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var busModel = await _context.BusData.FindAsync(id);
            _context.BusData.Remove(busModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusModelExists(int id)
        {
            return _context.BusData.Any(e => e.BusId == id);
        }
    }
}
