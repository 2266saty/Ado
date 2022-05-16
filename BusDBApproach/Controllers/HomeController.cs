using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;




namespace MyBusDBApproach.Controllers
{

    public class HomeController : Controller
    {
        MYBUSEntities1 entities1 = new MYBUSEntities1();
        public ActionResult Index()
        {
            return View(entities1.BusInfoes);
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