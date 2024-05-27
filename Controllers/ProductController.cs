using Microsoft.AspNetCore.Mvc;
using POE1.Models;

namespace POE1.Controllers
{
    public class ProductController : Controller
    {
        public productTable prodtbl = new productTable();



        [HttpPost]
        public ActionResult MyWorkPage(productTable products)
        {
            var result2 = prodtbl.insert_product(products);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult MyWorkPage()
        {
            return View(prodtbl);
        }
    }
}
