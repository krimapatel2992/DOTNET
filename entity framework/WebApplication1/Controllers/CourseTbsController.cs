using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CourseTbsController : Controller
    {
        private studentdemoEntities db = new studentdemoEntities();

        // GET: CourseTbs
        public ActionResult Index()
        {
            return View(db.CourseTbs.ToList());
        }

        // GET: CourseTbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseTb courseTb = db.CourseTbs.Find(id);
            if (courseTb == null)
            {
                return HttpNotFound();
            }
            return View(courseTb);
        }

        // GET: CourseTbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseTbs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseId,CourseName")] CourseTb courseTb,String var1,String var2)
        {
            if (ModelState.IsValid)
            {
                db.CourseTbs.Add(courseTb);
                db.SaveChanges();
                if(var1!=null && var2!=null)
                {
                    Session["sid"] = courseTb.CourseId;
                    return RedirectToAction(var1,var2);

                }
                return RedirectToAction("Index");
            }

            return View(courseTb);
        }

        // GET: CourseTbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseTb courseTb = db.CourseTbs.Find(id);
            if (courseTb == null)
            {
                return HttpNotFound();
            }
            return View(courseTb);
        }

        // POST: CourseTbs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseId,CourseName")] CourseTb courseTb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseTb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseTb);
        }

        // GET: CourseTbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseTb courseTb = db.CourseTbs.Find(id);
            if (courseTb == null)
            {
                return HttpNotFound();
            }
            return View(courseTb);
        }

        // POST: CourseTbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseTb courseTb = db.CourseTbs.Find(id);
            db.CourseTbs.Remove(courseTb);
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
    }
}
