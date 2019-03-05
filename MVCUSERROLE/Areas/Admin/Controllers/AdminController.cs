using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUSERROLE.Areas.Admin.Models;
using MVCUSERROLE.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace MVCUSERROLE.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext context;
        // GET: Admin/Admin
        VechicleRequisitionAdmin db = new VechicleRequisitionAdmin();


        public AdminController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
           // context.Users.ToList();
            //ViewBag.UserRole = new SelectList(context.Roles.ToList(), "Name", "Name");
            return View(context.Users.ToList());
        }


       
    }
}