using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionarySite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Missions()
        {
            return View();
        }

        // About Page
        public ActionResult About()
        {
            return View();
        }

        //Contact Page
        public ActionResult Contact()
        {
            return View();
        }
    }
}