using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSOrnek10.Models;

namespace AngularJSOrnek10.Controllers
{
    public class DefaultController : Controller
    {
        NorthwindEntities db;


        public DefaultController()
        {
            db = new NorthwindEntities();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllProducts()
        {
            var productList = db.Products.OrderByDescending(x => x.ProductID).Take(10).ToList();

            return Json(productList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteProduct(int id)
        {
            Product product = db.Products.Where(x => x.ProductID == id).FirstOrDefault();

            db.Products.Remove(product);
            db.SaveChanges();

            return Json("İşlem başarılı...");
        }

        [HttpPost]
        public JsonResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();

            return Json("İşlem başarılı...");
        }

        [HttpPost]
        public JsonResult UpdateProduct(Product product)
        {
            Product p = db.Products.Where(x => x.ProductID == product.ProductID).FirstOrDefault();

            p.ProductName = product.ProductName;
            p.Discontinued = product.Discontinued;

            db.SaveChanges();

            return Json("İşlem başarılı...");
        }
    }
}