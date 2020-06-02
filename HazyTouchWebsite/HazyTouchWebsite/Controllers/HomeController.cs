using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HazyTouchWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Home");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}