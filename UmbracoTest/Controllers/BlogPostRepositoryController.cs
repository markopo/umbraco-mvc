using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models; 
using Umbraco.Web.Mvc;
using UmbracoTest.Models; 

namespace UmbracoTest.Controllers
{
    public class BlogPostRepositoryController : RenderMvcController
    {

        public ActionResult BlogOverview(RenderModel model)
        {

            ViewBag.Title = "Blogs"; 

            var blogOverviewModel = new BlogOverviewModel(model.Content, Umbraco);

            return Index(new RenderModel(blogOverviewModel));
        }
    }
}