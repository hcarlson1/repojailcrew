using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new TestDBContext())
                {
               var test = new Test()
               {
                   UserName = "hi",
                   Email = "email@css.edu"
               };
                ctx.Test.Add(test);
                ctx.SaveChanges();
            }
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
        public ActionResult Calendar()
        {
            return View();
        }
    }
}