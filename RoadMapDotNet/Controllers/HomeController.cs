using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Math;

namespace RoadMapDotNet.Controllers
{
    public class HomeController : Controller
    {
        public int Number { get; set; } = 1;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var sin = Sin(Number);

            ViewBag.Message = $"{sin} Daniel's application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}