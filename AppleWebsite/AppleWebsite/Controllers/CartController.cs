using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppleWebsite.Models;
namespace AppleWebsite.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            AppleDBContext db = new AppleDBContext();
            List<Cart> carts = db.Carts.ToList();
            return View(carts);
        }
        public ActionResult Buy(int id, string storage)
        {
            AppleDBContext db = new AppleDBContext();
            List<Cart> carts = db.Carts.ToList();

            Cart item = db.Carts.Where(row => row.id_dev == id && row.storage==storage).FirstOrDefault();
            if(item == null)
			{
                item = new Cart();
                item.id_dev = id;
                item.quantity = 1;
                item.storage = storage;
                db.Carts.Add(item);
			}
            else// neu ton tai roi thi chi can tang so luong len
			{
                item.quantity++;
			}
                db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            AppleDBContext db = new AppleDBContext();
            Cart cart = db.Carts.Where(row => row.id_cart == id).FirstOrDefault() ;
            db.Carts.Remove(cart);
           
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}