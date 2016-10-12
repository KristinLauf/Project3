using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExceptionHandlingWeb.Code;

namespace ExceptionHandlingWeb.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();

        }


        public ActionResult IndexError()
        {
            Random rand = new Random();
            if (rand.Next(10) % 5 == 0)
            {
                throw new ArgumentException("index error");
            }
            return RedirectToAction("Index");
            
        }

        public ActionResult About()
        {
            Random rand = new Random();
            if (rand.Next(10) % 5 == 0)
            {
                throw new MyApplicationException("my app ex error");
            }
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            var ex = filterContext.Exception;
            Logger logger = new Logger();
            logger.LogException(ex);
        }
        
    }
}
