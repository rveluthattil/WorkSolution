using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewTabbed.Models;

namespace PartialViewTabbed.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TabView()
        {
            ViewBag.Message = "Tab View";
            return View();
        }

        //[AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult Tab3View()
        {
            ViewBag.Message = "Tab3View";
            List<AuditModel> aModel = new List<AuditModel>();
            for (int ctr = 1; ctr <= 10; ctr++)
                aModel.Add(new AuditModel
                {
                    intAuditId = ctr,
                    strAuditName = "Audit" + ((ctr <= 9) ? "0" + ctr.ToString() : ctr.ToString()),
                    dtmAuditDate = DateTime.Now
                });
            return PartialView("../Tab3View", aModel);
        }

        public ActionResult Tab4View()
        {
            ViewBag.Message = "Tab4View";
            List<AuditModel> aModel = new List<AuditModel>();
            for (int ctr = 1; ctr <= 10; ctr++)
                aModel.Add(new AuditModel
                {
                    intAuditId = ctr,
                    strAuditName = "Audit" + ((ctr <= 9) ? "0" + ctr.ToString() : ctr.ToString()),
                    dtmAuditDate = DateTime.Now
                });
            return PartialView("../Tab3View", aModel);
        }

        public ActionResult Tab5View()
        {
            ViewBag.Message = "Tab5View";
            List<AuditModel> aModel = new List<AuditModel>();
            for (int ctr = 1; ctr <= 10; ctr++)
                aModel.Add(new AuditModel
                {
                    intAuditId = ctr,
                    strAuditName = "Audit" + ((ctr <= 9) ? "0" + ctr.ToString() : ctr.ToString()),
                    dtmAuditDate = DateTime.Now
                });
            return PartialView("../Tab5View", aModel);
        }

    }
}