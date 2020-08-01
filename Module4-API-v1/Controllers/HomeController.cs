using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module4_API_v1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult getHTML()
        {
            ViewBag.Message = "Returning HTML in a partial view";

            return View();
        }
    }
}
