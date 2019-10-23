using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HolaMundoController : Controller
    {
        // GET: HolaMundo
        public string  Index()
        {
            return "Esta es la acción <b>predeterminada</b>";
        }

        // GET: HolaMundo/Bienvenido
        public string Bienvenido(string nombre, int veces = 1)
        {
            string cadena = "esto se repetira " + veces + " veces<br/>";
            for (int i = 0; i < veces; i++)
            {
                cadena += "hola " + nombre + "<br/>";
            }
            return cadena;
        }
    }
}