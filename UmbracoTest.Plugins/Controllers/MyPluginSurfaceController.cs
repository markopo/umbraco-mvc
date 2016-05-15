using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc; 
using Umbraco.Web.Mvc; 

namespace UmbracoTest.Plugins.Controllers
{
    [PluginController("UmbracoTestPlugins")]
    public class MyPluginSurfaceController : SurfaceController
    {

        public ActionResult Index()
        {
            return PartialView(); 
        }

    }
}
