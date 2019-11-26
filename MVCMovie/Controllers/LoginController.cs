using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMovie.Models;

namespace MVCMovie.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidateUser(UserModel currentUser)
        {
            string user = "admin";
            string password = "1234";
            if (user == currentUser.userName && password == currentUser.userPassword)
            {
                return RedirectToAction("Index", "Cinito");
            }
            else
            {
                return View("_WrongPassword");
            }
        }
    }
}