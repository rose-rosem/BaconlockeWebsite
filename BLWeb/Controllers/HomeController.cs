using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BLWeb.Models;

namespace BLWeb.Controllers
{
    public class HomeController : Controller
    {
        private CustomerEntities db = new CustomerEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Advantage()
        {
            return View();
        }

        public ActionResult Course()
        {
            return View();
        }

        public ActionResult StudentCase()
        {
            return View();
        }
        public ActionResult SoftDownload()
        {
            return View();
        }
        public ActionResult HelpFile()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Methodogy()
        {
            return View();
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            zq_CustomerTable zq_CustomerTable = db.zq_CustomerTable.Find(id);
            if (zq_CustomerTable == null)
            {
                return HttpNotFound();
            }
            return View(zq_CustomerTable);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "id,customerName,customerPhone,customerMessage")] zq_CustomerTable zq_CustomerTable)
        {
            if (ModelState.IsValid)
            {
                db.zq_CustomerTable.Add(zq_CustomerTable);
                db.SaveChanges();
                return RedirectToAction("Details", new { id = zq_CustomerTable.id });
            }

            return View(zq_CustomerTable);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact([Bind(Include = "id,customerName,customerPhone,customerMessage")] zq_CustomerTable zq_CustomerTable)
        {
            if (ModelState.IsValid)
            {
                db.zq_CustomerTable.Add(zq_CustomerTable);
                db.SaveChanges();
                return RedirectToAction("Details", new { id = zq_CustomerTable.id });
            }

            return View(zq_CustomerTable);
        }
    }
}