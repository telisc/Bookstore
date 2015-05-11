using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookstore.Models;
using Bookstore.DAL;

namespace Bookstore.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentRepository repository = new StudentRepository();
            return View(repository.List);
        }
        public ActionResult Create()
        {
            Student student = new Student();
            return View(student);
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            StudentRepository studentRepository = new StudentRepository();
            CourseRepository courseRepository = new CourseRepository();
            List<Course> courses = courseRepository.List.ToList();
            if (ModelState.IsValid)
            {
                student.Courses = new List<Course>();
                //find out if courses exist
                Course biologyCourse = courses.FirstOrDefault(x => x.CourseName == "Biology");
                if (biologyCourse != null )
                    student.Courses.Add(biologyCourse);
                else
                    student.Courses.Add(new Course { CourseName = "Biology" });

                Course historyCourse = courses.FirstOrDefault(x => x.CourseName == "History");
                if (biologyCourse != null)
                    student.Courses.Add(historyCourse);
                else
                    student.Courses.Add(new Course { CourseName = "History"});

                studentRepository.Add(student);
                return RedirectToAction("Index");
            }
            else
                return View(student);
        }
    }
}