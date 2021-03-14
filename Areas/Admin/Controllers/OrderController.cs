using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SDProject03.Data;
using SDProject03.Models;
using SDProject03.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject03.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _db;
      
        public OrderController(ApplicationDbContext _db)
        {
            this._db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }


        [Route("/checkout")]
        public IActionResult Checkout()
        {
            return View();
        }
        [Route("/checkout")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout (Order anOrder)
        {
            //List<HotelsModel> hc = HttpContext.Session.Get<List<HotelsModel>>("hotels");
            List<HotelsModel> hc = HttpContext.Session.Get<List<HotelsModel>>("hotels");
            if (hc != null)
            {
                foreach (var hotel in hc)
                {
                    OrderDetails od = new OrderDetails();
                    od.HotelsId = hotel.HotelsId;
                    anOrder.OrderDetails = new List<OrderDetails>();
                    anOrder.OrderDetails.Add(od);
                }
            }
            anOrder.OrderNo = GetOrderNo();
            _db.Orders.Add(anOrder);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("hotels", null);
            return View();
        }

        public string GetOrderNo()
        {
            int rowCount = _db.Orders.ToList().Count() + 1;
            return rowCount.ToString("000");

            
        }


      
    }
}
