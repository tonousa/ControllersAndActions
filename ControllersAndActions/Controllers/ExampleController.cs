using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        //
        // GET: /Example/

        public ViewResult Index()
        {
            //return View("~/Views/Other/Index.cshtml");
            //DateTime date = DateTime.Now;
            //ViewBag.Message = "Hello";
            //ViewBag.Date = DateTime.Now;
            ViewBag.Message = TempData["Message"];
            ViewBag.Date = TempData["Date"];
            return View();
        }

        //public RedirectResult Redirect()
        //{
        //    return Redirect("/Example/Index");
        //}

        //public RedirectToRouteResult Redirect()
        //{
        //    return RedirectToRoute(new
        //    {
        //        controller = "Example",
        //        action = "Index",
        //        ID = "MyID"
        //    });
        //}

        public RedirectToRouteResult Redirect()
        {
            return RedirectToAction("Index", "Basic");
        }

        public RedirectToRouteResult RedirectToRoute()
        {
            TempData["Message"] = "Hello from RtoR";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
        }

        public HttpStatusCodeResult StatusCode()
        {
            //return new HttpStatusCodeResult(404, "URL cannot be serviced");
            return HttpNotFound();
        }
    }
}
