using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the derived controller Index method";
            return View("MyView");
        }

        public void ProduceOutput()
        {
            if (Server.MachineName == "TYNY")
            {
                Response.Redirect("/Basic/Index");
            }
            else
            {
                Response.Write("Controller: Derived, Aciton: ProduceOutput");
            }
        }
    }
}