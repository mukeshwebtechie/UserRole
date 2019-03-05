using MVCUSERROLE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUSERROLE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            UserManage myusr = new UserManage();
            myusr.GetUserRole("mukesh.webtechie1@gmail.com");
            
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
    }
}