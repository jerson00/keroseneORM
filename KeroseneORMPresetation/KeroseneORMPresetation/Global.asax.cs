using KeroseneORMPresetation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KeroseneORMPresetation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IDbConnection KeroseneConnection;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            KeroseneConnection = KeroseneConection.Conection();
        }
    }
}
