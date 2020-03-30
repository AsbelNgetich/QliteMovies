using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Newtonsoft.Json.Serialization;

namespace MovieRentals.App_Start
{
    public class WebApiConfig
    {

       
            public static void Register(HttpConfiguration config)
            {
                var settings = config.Formatters.JsonFormatter.SerializerSettings;
                settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                config.MapHttpAttributeRoutes();
                settings.Formatting = Newtonsoft.Json.Formatting.Indented;

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );
            }
        

    }
}