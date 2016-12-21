using System.Web.Http;
using System.Web.Http.OData.Builder;

namespace Northwind.Web
{
    public static class ODataConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();

            builder.EntitySet<Entities.Models.tblUser>(typeof(Entities.Models.tblUser).Name);
           
            
           
            var model = builder.GetEdmModel();
            config.Routes.MapODataRoute("odata", "odata", model);
      

            config.EnableQuerySupport();
        }
    }
}