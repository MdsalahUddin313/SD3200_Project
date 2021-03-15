using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SDProject03.Data;
using SDProject03.Models;
using SDProject03.Utility;

namespace SDProject03.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CheckOutsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CheckOutsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("/checkouts/index")]
        // GET: Admin/CheckOuts
        public async Task<IActionResult> Index()
        {
            return View(await _context.CheckOut.ToListAsync());
        }

        // GET: Admin/CheckOuts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkOut = await _context.CheckOut
                .FirstOrDefaultAsync(m => m.Id == id);
            if (checkOut == null)
            {
                return NotFound();
            }

            return View(checkOut);
        }

       
        [Route("/checkouts/create")]

        // GET: Admin/CheckOuts/Create
        public IActionResult Create()
        {
            return View();
        }


            //if(hotels == null)
           // {
            //    hotels = new List<HotelsModel>();

           // }
          //  return View(hotels);

    [Route("/checkouts/create")]
        // POST: Admin/CheckOuts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,CardNo,CardPin,ExpireDate,PaymentAmount")] CheckOut checkOut)
        {
        List<HotelsModel> hotels = HttpContext.Session.Get<List<HotelsModel>>("hotels");


        if (ModelState.IsValid)
            {
                _context.Add(checkOut);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(checkOut);
        }

        // GET: Admin/CheckOuts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkOut = await _context.CheckOut.FindAsync(id);
            if (checkOut == null)
            {
                return NotFound();
            }
            return View(checkOut);
        }

        // POST: Admin/CheckOuts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,CardNo,CardPin,ExpireDate,PaymentAmount")] CheckOut checkOut)
        {
            if (id != checkOut.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(checkOut);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CheckOutExists(checkOut.Id))
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
            return View(checkOut);
        }

        // GET: Admin/CheckOuts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkOut = await _context.CheckOut
                .FirstOrDefaultAsync(m => m.Id == id);
            if (checkOut == null)
            {
                return NotFound();
            }

            return View(checkOut);
        }

        // POST: Admin/CheckOuts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var checkOut = await _context.CheckOut.FindAsync(id);
            _context.CheckOut.Remove(checkOut);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CheckOutExists(int id)
        {
            return _context.CheckOut.Any(e => e.Id == id);
        }
    }
}
