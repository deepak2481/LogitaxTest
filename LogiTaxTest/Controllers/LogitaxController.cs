using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogiTaxTest.Controllers
{
    public class LogitaxController : Controller
    {
        //
        // GET: /Logitax/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Logitax/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Logitax/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Logitax/Create

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

        //
        // GET: /Logitax/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Logitax/Edit/5

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

        //
        // GET: /Logitax/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Logitax/Delete/5

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
