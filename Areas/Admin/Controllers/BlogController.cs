using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDProject03.Data;
using SDProject03.Models;
using SDProject03.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject03.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class BlogController : Controller
    {
        private ApplicationDbContext _db;

        public BlogController (ApplicationDbContext _db)
        {
            this._db = _db;
        }

        [Route("/hotels")]
        
        public IActionResult HotelsIndex()
        {
            return View(_db.HotelsData.ToList());
        }

        [Route("/hotels")]

        [HttpPost]
        public IActionResult HotelsIndex(String? Hotelsmap )
        {
            var products = _db.HotelsData.Where(c => c.HotelsMap == Hotelsmap).ToList();
           if(Hotelsmap == null)
            {
                products = _db.HotelsData.ToList();

            }
            return View(products);
        }

        [Route("/details/{id}")]
        // GET: Admin/HotelsModels/Delete/5
        public async Task<IActionResult> HotelDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelsModel = await _db.HotelsData
                .FirstOrDefaultAsync(m => m.HotelsId == id);
            if (hotelsModel == null)
            {
                return NotFound();
            }

            return View(hotelsModel);
        }

        [Route("/details/{id}")]
        // GET: Admin/HotelsModels/Delete/5
        [HttpPost]
        [ActionName("HotelDetails")]
        public async Task<IActionResult> HotelCartDetails(int? id)
        {
            List<HotelsModel> hc = new List<HotelsModel>();


            if (id == null)
            {
                return NotFound();
            }

            var hotelsModel = await _db.HotelsData
                .FirstOrDefaultAsync(m => m.HotelsId == id);
            if (hotelsModel == null)
            {
                return NotFound();
            }
            hc = HttpContext.Session.Get<List<HotelsModel>>("hotels");
            if(hc== null)
            {
                hc = new List<HotelsModel>();
            }
            hc.Add(hotelsModel);
            HttpContext.Session.Set("hotels", hc);
                
           return View(hotelsModel);
        }

        [Route("/remove/{id}")]
        //Session Remove from data
        [ActionName("Remove")]
        // GET: Admin/HotelsModels/Delete/5
        //[HttpPost]
        //[ActionName("HotelDetails")]
        public IActionResult RemoveToCart(int? id)
        {
            List<HotelsModel> hotels = HttpContext.Session.Get<List<HotelsModel>>("hotels");

            // List<HotelsModel> hc = new List<HotelsModel>();

            if (hotels != null)
            {
                var hotel = hotels.FirstOrDefault(c => c.HotelsId == id);
                if (hotel != null)
                {
                    hotels.Remove(hotel);
                    HttpContext.Session.Set("hotels", hotels);

                }
            }
            return RedirectToAction(nameof(HotelsIndex));


        }

        //<Button type="submit" value="Remove To Cart" class="btn btn-danger" asp-action="Remove" asp-controller="BlogController" asp-route-id="@Model.HotelsId">Remove From Cart</Button>
        

        //Session Remove from data
        [Route("/remove/{id}")]
        // GET: Admin/HotelsModels/Delete/5
        [HttpPost]
        //[ActionName("HotelDetails")]
        public IActionResult Remove(int? id)
        {
            List<HotelsModel> hotels = HttpContext.Session.Get<List<HotelsModel>>("hotels");

            // List<HotelsModel> hc = new List<HotelsModel>();

            if (hotels != null)
            {
                var hotel = hotels.FirstOrDefault(c => c.HotelsId == id);
                if(hotel != null)
                {
                    hotels.Remove(hotel);
                    HttpContext.Session.Set("hotels", hotels);

                }
            }
            return RedirectToAction(nameof(HotelsIndex));

            
        }



        [Route("/Blogs")]
        public IActionResult Index()
        {

            return View(_db.BlogsPost.ToList());
        }

        [Route("/blog/details/{id}")]
        // GET: Admin/HotelsModels/Delete/5
        public async Task<IActionResult> BlogDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelsModel = await _db.BlogsPost
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (hotelsModel == null)
            {
                return NotFound();
            }

            return View(hotelsModel);
        }

      


        [Route("/cart")]

        public IActionResult Cart()
        {
            List<HotelsModel> hotels = HttpContext.Session.Get<List<HotelsModel>>("hotels");
            if(hotels == null)
            {
                hotels = new List<HotelsModel>();

            }
            return View(hotels);
        }

        














        [Route("/transport")]

        public IActionResult TransportIndex()
        {
            return View();
        }



        [Route("/Locations")]

        public IActionResult LocationsViewsIndex()
        {
            return View(_db.Location.ToList());
        }

        [Route("/Locations")]
        [HttpPost]
        public IActionResult LocationsViewsIndex(String? cityName)
        {
            var loc = _db.Location.Where(c => c.LocationName == cityName).ToList();
            if (cityName == null)
            {
                loc = _db.Location.ToList();

            }
            return View(loc);
        }










        [Route("/Locations/details/{id}")]
        // GET: Admin/HotelsModels/Delete/5
        public async Task<IActionResult> LocationsDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationModel = await _db.Location
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (locationModel == null)
            {
                return NotFound();
            }

            return View(locationModel);
        }



        [Route("/checkout")]
        public IActionResult CheckOutIndex()
        {
            return View();
        }


        [Route("/favlist")]

        public IActionResult FavouriteListIndex()
        {
            return View();
        }


        [Authorize]

        [Route("/Dashboard")]

        public IActionResult DashboardIndex()
        {
            return View();
        }




    }
}
