﻿using MVCUSERROLE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUSERROLE.Controllers
{
    public class RequestController : Controller
    {
        // GET: Request
        //ApplicationDbContext context;

        //public RequestController()
        //{
        //    context = new ApplicationDbContext();
        //}




     
        public ActionResult Index()
        {
            //Session["Role"] = "User";
            //var RequisitionList = db.RequisitionMasters.ToList();


            return View();
            
        }

        // GET: Request/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Request/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Request/Create
        [HttpPost]
        public ActionResult Create(VehicleRequisition VehicleRequisition)
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

        // GET: Request/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Request/Edit/5
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

        // GET: Request/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Request/Delete/5
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
    }
}
