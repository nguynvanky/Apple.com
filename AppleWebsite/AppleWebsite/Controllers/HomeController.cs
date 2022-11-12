using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppleWebsite.Models;
namespace AppleWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetNavBar()
        {
            AppleDBContext db = new AppleDBContext();
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }
    }
}