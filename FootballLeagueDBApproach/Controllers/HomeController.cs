using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballLeague2;



namespace FootballLeague2.Controllers
{
    public class HomeController : Controller
    {
        mydatabaseEntities1 context = new mydatabaseEntities1();
        public ActionResult Index()
        {
            return View(context.FootballLeagues);
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
    }
}