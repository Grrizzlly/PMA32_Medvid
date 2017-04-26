using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBProg.Models;
namespace DBProg.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
           // ViewBag.Message = "Измените этот шаблон, чтобы быстро приступить к работе над приложением ASP.NET MVC.";

            return View(db.Books);
        }

        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
