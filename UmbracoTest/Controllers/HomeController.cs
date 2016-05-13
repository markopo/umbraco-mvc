using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UmbracoTest.Helpers;
using UmbracoTest.Extensions;
using Umbraco.Web;
using Umbraco.Web.Models;
using System.Threading;

namespace UmbracoTest.Controllers
{
    public class HomeController : Controller
    {

        private readonly UmbracoContext umbracoContext; 

        public HomeController()
        {
            umbracoContext = UmbracoContext.Current; 
        }

        // GET: Home
        public ActionResult Index()
        {
            var home = umbracoContext.ContentCache.GetById(1063);
            var siteTitle = home.GetPropertyValue<string>("siteTitle");
            ViewBag.SiteTitle = siteTitle;

            var model = new RenderModel(home, Thread.CurrentThread.CurrentCulture); 

            return View(model);
        }

        [HttpGet]
        public JsonResult GetCurrentDate()
        {
            return Json(DateTime.Now.ToString("yyyy-MM-dd"), JsonRequestBehavior.AllowGet); 
        }

        [HttpGet]
        public JsonResult GetHomeNode()
        {
            var home = Helpers.UmbracoHelper.GetHomeNode(); 
            return Json(home.Properties.ToAliasValues(), JsonRequestBehavior.AllowGet); 
        }
    }
}