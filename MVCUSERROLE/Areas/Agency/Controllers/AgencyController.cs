using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUSERROLE.Areas.Agency.Models;

namespace MVCUSERROLE.Areas.Agency.Controllers
{
    public class AgencyController : Controller
    {

        // GET: Agency/Agency
        VechicleAgency db = new VechicleAgency();
        public ActionResult Index()
        {
            return View();
        }
    }
}