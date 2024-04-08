using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorEngine;
using RazorEngine.Templating;

namespace HealthSupportApp.Controllers
{
    public class RazorPageController : Controller
    {
        // GET: RazorPage
        [Obsolete]
        public ActionResult Index()
        {
            var razorTpl = "Hello !";
            ViewBag.RenderedTemplate = Razor.Parse(razorTpl);
            return View();
        }
                
        [Obsolete]
        [ValidateInput(false)]
        public ActionResult Demo(string name)
        {
            var razorTpl = $"Hello User {name}!";
            ViewBag.RenderedTemplate = Razor.Parse(razorTpl);
            ViewBag.Template = razorTpl;

            //var razorTpl = "Hello @Model.name!";
            //ViewBag.RenderedTemplate = Engine.Razor.RunCompile(razorTpl, "templateKey", null, new { name = name });
            return View("Index");
        }
    }
}