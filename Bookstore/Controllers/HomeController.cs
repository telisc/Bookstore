using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Telis Cosmas test application using MVC & Entity Framework.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "telisck@yahoo.com.";

            return View();
        }
        public String SaySomething()
        {
            return "Ajax call return "  + DateTime.Now;
        }
    }
}