using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleAccMVC.Controllers
{
    public class GoogleAccController : Controller
    {
        // GET: GoogleAcc
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GoogAcc()
        {
            return View();
        }

        // GET: GoogleAcc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GoogleAcc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoogleAcc/Create
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

        // GET: GoogleAcc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GoogleAcc/Edit/5
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

        // GET: GoogleAcc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GoogleAcc/Delete/5
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
