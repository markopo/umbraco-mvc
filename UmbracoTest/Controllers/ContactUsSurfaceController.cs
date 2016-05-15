using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 
using Umbraco.Web.Mvc;
using UmbracoTest.Models;
using System.Xml.Linq; 

namespace UmbracoTest.Controllers
{
    public class ContactUsSurfaceController : SurfaceController
    {

        public ActionResult Index(ContactUsModel model)
        {
            if(!string.IsNullOrEmpty(model.Name) && !string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Message) )
            {
                var path = Server.MapPath("~/App_Data/ContactUs.xml");
                var xdoc = XDocument.Load(path);
                xdoc.Element("ContactUs").Add(new XElement("Contact",
                    new XElement("Name", model.Name),
                    new XElement("Email", model.Email),
                    new XElement("Message", new XCData(model.Message))));
                xdoc.Save(path); 


            }

            return RedirectToCurrentUmbracoPage(); 
        }

    }
}