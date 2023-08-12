using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public static List<Student> students=new List<Student>();

        public StudentController()
        {
            if(students.Count==0)
            {
                students.Add(new Student { Id = 1, Name = "njdw", Age = 14 });
                students.Add(new Student { Id = 2, Name = "pofd", Age = 15 });
                students.Add(new Student { Id = 3, Name = "abc", Age = 10 });

            }
            
        }
        public ActionResult Index()
        {
            return View(students.ToList());
        }

        private Student GetStudentByID(int id)
        {
            return students.Where(s => s.Id == id).SingleOrDefault();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            Student stud = students.Where(s => s.Id == id).FirstOrDefault();

            return View(stud);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
                return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student newstudent)
        {
            try
            {
                // TODO: Add insert logic here
                newstudent.Id = students.Max(s => s.Id)+1;
                students.Add(newstudent);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            Student ste = students.SingleOrDefault(s => s.Id == id);
            return View(ste);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student studenttoupdate)
        {
            try
            {
                Student stu = GetStudentByID(id);
                stu.Name = studenttoupdate.Name;
                stu.Age = studenttoupdate.Age;
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student std = GetStudentByID(id);
            return View(std);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                students.Remove(GetStudentByID(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
