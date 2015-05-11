using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookstore.DAL;
namespace Bookstore.DAL
{
    public class StudentRepository :IRepository<Student>,IDisposable 
    {
        private StudentContext _context;
        public StudentRepository()
        {
            _context = new StudentContext();
        }
        public IEnumerable<Student> List
        {
            get
            {
                return _context.Students;
            }
        }
        private bool bIsDisposed = false;
        public void Dispose(bool isDisposing)
        {
            if(!bIsDisposed)
            {
                if(isDisposing)
                {
                    _context.Dispose();
                }
                bIsDisposed = true;
            }
        }
        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public Student FindByID( int id )
        {
            return _context.Students.FirstOrDefault(x => x.ID == id);
        }
        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void Update(Student student)
        {
            _context.Entry(student).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}

