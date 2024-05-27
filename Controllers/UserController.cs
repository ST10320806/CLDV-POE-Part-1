using Microsoft.AspNetCore.Mvc;
using POE1.Models;

namespace POE1.Controllers
{
    public class UserController : Controller
    {
        public userTable usrtbl = new userTable();



        [HttpPost]
        public ActionResult About(userTable Users)
        {
            var result = usrtbl.insert_User(Users);
            return RedirectToAction("Login", "Home");
        }

        [HttpGet]
        public ActionResult About()
        {
            return View(usrtbl);
        }

    }
}
