using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionarySite.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            SelectListItem item1 = new SelectListItem()
            { Text = "MissionA", Value = "1", Selected = true };
            SelectListItem item2 = new SelectListItem()
            { Text = "MissionB", Value = "2", Selected = false };
            SelectListItem item3 = new SelectListItem()
            { Text = "MissionC", Value = "3", Selected = false };

            items.Add(item1);
            items.Add(item2);
            items.Add(item3);


            ViewBag.Mission = items;

            return View();
        }

        public ActionResult Show()
        {

            return View();
        }
    }
}