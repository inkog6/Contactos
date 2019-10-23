using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class AlternoController : Controller
    {
        // GET: Alterno
        public string Index(int id)
        {
            return "El valor de <b>id</b> es " + id;
        }
    }
}