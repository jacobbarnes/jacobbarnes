using MissionarySite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionarySite.Controllers
{
    public class MissionController : Controller
    {
        public static List<Mission> lstMission = new List<Mission>()
        {
            new Mission {Name = "Mission A", Code = "A"},
            new Mission {Name = "Mission B", Code = "B"},
            new Mission {Name = "Mission C", Code = "C"}
        };

        // GET: Mission
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.MissionStuff = lstMission;
            return View();
        }

        [HttpPost]
        public ActionResult Index(Mission oMission)
        {
            
            ViewBag.MissionName = oMission.Name;
            return View("FAQ");

        }
    }
}