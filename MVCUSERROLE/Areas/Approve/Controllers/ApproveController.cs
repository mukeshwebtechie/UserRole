using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUSERROLE.Models;

namespace MVCUSERROLE.Areas.Approve.Controllers
{
    public class ApproveController : Controller
    {
       
        // GET: Approve/Approve
        public ActionResult Index()
        {
            //var RequisitionList = db.RequisitionMasters.ToList();
            return View();
        }

        // GET: Approve/Approve/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Approve/Approve/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Approve/Approve/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Approve/Approve/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Approve/Approve/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Approve/Approve/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Approve/Approve/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        public ActionResult Approve()
        {
            return View();
        }


        public ActionResult Decline()
        {
            return View();
        }
    }
}
