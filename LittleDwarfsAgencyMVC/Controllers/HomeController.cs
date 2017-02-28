using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LittleDwarfsAgencyMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Little Dwarfs Care Agency";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Mike Brown.";

            return View();
        }
    }
}