using System.Web.Http;

namespace Northwind.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
           
        
        // Web API routes
        config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
               name: "DefaultApi1",
               routeTemplate: "odata/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );
            config.Routes.MapHttpRoute(
               name: "DefaultApi2",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );
        }
    }
}
