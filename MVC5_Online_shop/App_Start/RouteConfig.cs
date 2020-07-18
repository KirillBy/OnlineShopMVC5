﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5_Online_shop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("SidebarPartial", "Pages/SidebarPartial", new { controller = "Pages", action = "SidebarPartial" },
                 new[] { "MVC5_Online_shop.Controllers" });

            routes.MapRoute("Shop", "Shop/{action}/{name}", new { controller = "Shop", action = "Index", name = UrlParameter.Optional },
                 new[] { "MVC5_Online_shop.Controllers" });

            routes.MapRoute("PagesMenuPartial", "Pages/PagesMenuPartial", new { controller = "Pages", action = "PagesMenuPartial" },
                new[] { "MVC5_Online_shop.Controllers" });

            routes.MapRoute("Default", "", new { controller = "Pages", action = "Index" },
                    new[] { "MVC5_Online_shop.Controllers" });

            routes.MapRoute("Pages", "{page}", new { controller = "Pages", action = "Index" },
                     new[] { "MVC5_Online_shop.Controllers" });
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
