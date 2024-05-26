using KhumaloCraft.Models;
using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft.Controllers
{
    public class ProductController : Controller
    {
        public productTable prodtbl = new productTable();



        [HttpPost]
        public ActionResult MyWork(productTable products)
        {
            var result2 = prodtbl.insert_product(products);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult MyWork()
        {
            return View(prodtbl);
        }
    }
}
