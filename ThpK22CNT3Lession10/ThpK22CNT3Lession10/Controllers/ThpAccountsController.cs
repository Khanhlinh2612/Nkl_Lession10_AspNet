using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThpK22CNT3Lession10.Models;

namespace ThpK22CNT3Lession10.Controllers
{
    public class ThpAccountsController : Controller
    {
        private ThpK22CNT3Lession10DbEntities db = new ThpK22CNT3Lession10DbEntities();

        // GET: ThpAccounts
        public ActionResult Index()
        {
            return View(db.ThpAccounts.ToList());
        }

        // GET: ThpAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThpAccount thpAccount = db.ThpAccounts.Find(id);
            if (thpAccount == null)
            {
                return HttpNotFound();
            }
            return View(thpAccount);
        }

        // GET: ThpAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThpAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ThpID,ThpUserName,ThpPassword,ThpFullName,ThpEmail,ThpPhone,ThpActive")] ThpAccount thpAccount)
        {
            if (ModelState.IsValid)
            {
                db.ThpAccounts.Add(thpAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thpAccount);
        }

        // GET: ThpAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThpAccount thpAccount = db.ThpAccounts.Find(id);
            if (thpAccount == null)
            {
                return HttpNotFound();
            }
            return View(thpAccount);
        }

        // POST: ThpAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ThpID,ThpUserName,ThpPassword,ThpFullName,ThpEmail,ThpPhone,ThpActive")] ThpAccount thpAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thpAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thpAccount);
        }

        // GET: ThpAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThpAccount thpAccount = db.ThpAccounts.Find(id);
            if (thpAccount == null)
            {
                return HttpNotFound();
            }
            return View(thpAccount);
        }

        // POST: ThpAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThpAccount thpAccount = db.ThpAccounts.Find(id);
            db.ThpAccounts.Remove(thpAccount);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        //login
        public ActionResult ThpLogin()
        {
            var  thpModel = new ThpAccount();
            return View(thpModel);
        }

        [HttpPost]
        public ActionResult ThpLogin(ThpAccount thpAccount)
        {
            var thpCheck= db.ThpAccounts.Where(x=>x.ThpUserName.Equals(thpAccount.ThpUserName) && x.ThpPassword.Equals(thpAccount.ThpPassword)).FirstOrDefault();
            if (thpCheck != null)
            {
                //save sesstion
                Session["ThpAccount"] = thpCheck;
                return Redirect("/");
            }
            return View(thpAccount);
        }
    }
}
