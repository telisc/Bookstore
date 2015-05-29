using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookstore.DAL;
using System.Threading;

namespace Bookstore.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            CategoryRepository repo = new CategoryRepository();
            return View(repo.List);
        }
        public string DoAjax()
        {
            Thread.Sleep(5000);  // Added a thread.sleep() to show the loading panel for some more time. 

            return ("This data is fetched through ajax call. ");
        }
    }
}