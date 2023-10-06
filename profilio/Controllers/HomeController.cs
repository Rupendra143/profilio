using profilio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace profilio.Controllers
{
    public class HomeController : Controller
    {
        PortfolioEntities db = new PortfolioEntities();
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
        public ActionResult Profilio()
        {
            return View();
        } 
        public ActionResult ProfilioFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProfilioFile(datum dt)
        {
            dt.Crd = DateTime.Now;
            db.data.Add(dt);
            db.SaveChanges();
            return View();
        }
    }
}