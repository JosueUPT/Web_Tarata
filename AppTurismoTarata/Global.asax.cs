using AppTurismoTarata.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AppTurismoTarata
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_BeginRequest()
        {
            var middleware = new RequestLoggingMiddleware();
            middleware.ProcessRequestAsync(HttpContext.Current).GetAwaiter().GetResult();
        }
    }
}
