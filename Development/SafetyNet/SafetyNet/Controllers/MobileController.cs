using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SafetyNet.Controllers
{
    public class MobileController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Alert");
        }
        // GET: Mobile
        public ActionResult Alert()
        {
            return View("AlertView");
        }
        public ActionResult Calm()
        {
            return View("CalmView");
        }
        public ActionResult Map()
        {
            return View("MapView");
        }
        public ActionResult Update()
        {
            return View("UpdateView");
        }
        public ActionResult Confirm()
        {
            return View("ConfirmView");
        }
    }
}