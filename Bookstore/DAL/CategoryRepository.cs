using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookstore.DAL;
using Bookstore.Models;

namespace Bookstore.DAL
{
    public class CategoryRepository : IRepository<Category>
    {
        private CategoryContext  _context;

        public CategoryRepository()
        {
            _context = new CategoryContext();
        }

        public IEnumerable<Category> List
        {
            get {
                return _context.categories;
                }
        }

        public void Add(Category entity)
        {
            _context.categories.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            _context.categories.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Category entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public Category FindByID(int id)
        {
            Category category = _context.categories.SingleOrDefault(x => x.CategoryID == id);
            return category;
        }
    }
}