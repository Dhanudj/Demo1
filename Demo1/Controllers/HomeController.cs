using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Devops Menu";
            ViewBag.Name = "Dhanu";
            ViewBag.Team = "Devops Group";
            ViewBag.Tools = "Azure/VSTS";
            ViewBag.Server = "IIS Server/Windows Server";
                       return View();
        }
    }
}
