using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute("Bienvenido", "Bienvenido", defaults: new { controller = "HolaMundo", action = "Bienvenido" });

            routes.MapRoute(
                name: "Bienvenido",
                url: "Bienvenido{nombre}/{veces}",
                defaults: new
                {
                    controller = "HolaMundo",
                    action = "Bienvenido",
                    nombre = UrlParameter.Optional,
                    veces = UrlParameter.Optional}
                //nombre = "Juan",
                   // veces = 5}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Cinito", action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "Acceso", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
