using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class CinitoController : Controller
    {
        // GET: Cinito
        public ActionResult Index()
        {
            return View();
        }
    }
}