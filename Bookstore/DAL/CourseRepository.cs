using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.DAL
{
    public class CourseRepository:IRepository<Course>
    {
        private CourseContext _context;
        public CourseRepository()
        {
            _context = new CourseContext();
        }
        public IEnumerable<Course> List
        {
            get{
                return _context.Courses.ToList();
            }
        }
        public Course FindByID(int ID)
        {
            Course course = _context.Courses.SingleOrDefault(x => x.ID == ID);
            return course;
        }
        public Course FindByName(String name)
        {
            Course course = _context.Courses.Single(x => x.CourseName  == name);
            return course;
        }
        public void Update(Course course)
        {
            _context.Entry(course).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(Course course)
        {
            _context.Entry(course).State = System.Data.Entity.EntityState.Deleted;
            _context.SaveChanges();
        }
        public void Add(Course course)
        {
            _context.Courses.Add(course);
        }
    }
}