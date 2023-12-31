﻿using System;
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
    public class StudentTbsController : Controller
    {
        private studentdemoEntities db = new studentdemoEntities();

        // GET: StudentTbs
        public ActionResult Index()
        {
            var studentTbs = db.StudentTbs.Include(s => s.CourseTb);
            return View(studentTbs.ToList());
        }

        // GET: StudentTbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTb studentTb = db.StudentTbs.Find(id);
            if (studentTb == null)
            {
                return HttpNotFound();
            }
            return View(studentTb);
        }

        // GET: StudentTbs/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.CourseTbs, "CourseId", "CourseName",Session["sid"]);
            return View();
        }

        // POST: StudentTbs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,semester,CourseId")] StudentTb studentTb)
        {
            if (ModelState.IsValid)
            {
                db.StudentTbs.Add(studentTb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.CourseTbs, "CourseId", "CourseName", studentTb.CourseId);
            return View(studentTb);
        }

        // GET: StudentTbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTb studentTb = db.StudentTbs.Find(id);
            if (studentTb == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.CourseTbs, "CourseId", "CourseName", studentTb.CourseId);
            return View(studentTb);
        }

        // POST: StudentTbs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,semester,CourseId")] StudentTb studentTb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentTb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.CourseTbs, "CourseId", "CourseName", studentTb.CourseId);
            return View(studentTb);
        }

        // GET: StudentTbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTb studentTb = db.StudentTbs.Find(id);
            if (studentTb == null)
            {
                return HttpNotFound();
            }
            return View(studentTb);
        }

        // POST: StudentTbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentTb studentTb = db.StudentTbs.Find(id);
            db.StudentTbs.Remove(studentTb);
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
