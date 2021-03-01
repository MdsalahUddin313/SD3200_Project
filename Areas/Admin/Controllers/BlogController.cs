using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject03.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]
    public class BlogController : Controller
    {

        [Route("/Blogs")]
        public IActionResult Index()
        {

            return View();
        }

        [Route("/hotels")]
        public IActionResult HotelsIndex()
        {
            return View();
        }

        [Route("/transport")]

        public IActionResult TransportIndex()
        {
            return View();
        }

        [Route("/Locations")]

        public IActionResult LocationsIndex()
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
