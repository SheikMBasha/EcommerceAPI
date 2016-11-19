using AuthenticationService.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AuthenticationService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //var corsAttr = new EnableCorsAttribute("http://localhost:63342", "*", "*");
            var corsAttr = new EnableCorsAttribute("http://mykart", "*", "*");
            config.EnableCors(corsAttr);

            // Web API routes

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
            );

            StructuremapWebApi.Start();
        }
    }
}
