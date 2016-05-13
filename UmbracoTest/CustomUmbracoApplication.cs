using System;
using System.Web.Mvc;
using System.Web.Routing; 
using Umbraco.Core;
using Umbraco.Web;

namespace UmbracoTest
{
    public class CustomUmbracoApplication : UmbracoApplication
    {
        protected override IBootManager GetBootManager()
        {
            return new CustomWebBootManager(this); 
        }
    }

    class CustomWebBootManager : WebBootManager
    {
        public CustomWebBootManager(UmbracoApplicationBase application) : base(application)
        {


        }

        public override IBootManager Complete(Action<ApplicationContext> afterComplete)
        {
            RouteTable.Routes.MapRoute("HomePage", "home/index", new { controller = "Home", action = "Index" });
            RouteTable.Routes.MapRoute("GetCurrentDate", "home/getcurrentdate", new { controller = "Home", action = "GetCurrentDate" }); 
            RouteTable.Routes.MapRoute("GetHomeNode", "home/gethomenode", new { controller = "Home", action = "GetHomeNode" });



            return base.Complete(afterComplete);
        }

    }
}