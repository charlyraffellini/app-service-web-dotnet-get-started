using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.TraceError("Index() hitted");
            return View();
        }

        public ActionResult About()
        {
            System.Diagnostics.Trace.TraceError("About() hitted");
            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            System.Diagnostics.Trace.TraceError("Contact() hitted");
        
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
