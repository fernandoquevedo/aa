using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Raven.Client.Documents;

namespace irad
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static DocumentStore Store;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RavenDBInit();
        }
        private static void RavenDBInit()
        {

            Store = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080" },
                Database = "radio"
            };

            Store.Initialize();

        }

    }
}
