using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUSERROLE.Models;

namespace MVCUSERROLE.Areas.Employee.Controllers
{
    public class VehicleRequisitionController : Controller
    {
        // GET: Employee/VehicleRequisitionForEmployee
     
        public ActionResult Index()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Index(VehicleRequisition VehicleRequisition)
        {
            //db.RequisitionMasters.Add(VehicleRequisition);
            //db.SaveChanges();

            return View();
        }

       


    }
}