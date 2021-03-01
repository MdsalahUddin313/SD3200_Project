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
    public class TrainModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrainModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/TrainModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Train.ToListAsync());
        }

        // GET: Admin/TrainModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainModel = await _context.Train
                .FirstOrDefaultAsync(m => m.TrainId == id);
            if (trainModel == null)
            {
                return NotFound();
            }

            return View(trainModel);
        }

        // GET: Admin/TrainModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TrainModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrainId,TrainName,TrainCompanyName,TrainTitle,TrainDescription,TrainMap,TrainRating,TrainSeatType,TrainSeatPrice,DepartureTime,TrainDepartureLocation,TrainArrivalLocation,ArrivalTime,ImageName")] TrainModel trainModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trainModel);
        }

        // GET: Admin/TrainModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainModel = await _context.Train.FindAsync(id);
            if (trainModel == null)
            {
                return NotFound();
            }
            return View(trainModel);
        }

        // POST: Admin/TrainModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TrainId,TrainName,TrainCompanyName,TrainTitle,TrainDescription,TrainMap,TrainRating,TrainSeatType,TrainSeatPrice,DepartureTime,TrainDepartureLocation,TrainArrivalLocation,ArrivalTime,ImageName")] TrainModel trainModel)
        {
            if (id != trainModel.TrainId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainModelExists(trainModel.TrainId))
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
            return View(trainModel);
        }

        // GET: Admin/TrainModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainModel = await _context.Train
                .FirstOrDefaultAsync(m => m.TrainId == id);
            if (trainModel == null)
            {
                return NotFound();
            }

            return View(trainModel);
        }

        // POST: Admin/TrainModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainModel = await _context.Train.FindAsync(id);
            _context.Train.Remove(trainModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainModelExists(int id)
        {
            return _context.Train.Any(e => e.TrainId == id);
        }
    }
}
