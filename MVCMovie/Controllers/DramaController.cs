using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class DramaController : Controller
    {
        // GET: Drama
        public ActionResult Index()
        {
            return View();
        }
    }
}