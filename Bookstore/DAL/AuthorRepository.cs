using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Bookstore.Models;

namespace Bookstore.DAL
{
    public class AuthorRepository :IAuthorRepository 
    {
        private AuthorContext _context;

        public AuthorRepository(AuthorContext authorContext)
        {
            this._context = authorContext;
        }
        public IEnumerable<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthorByID(int id)
        {
            return _context.Authors.Single(x => x.Id == id);
        }

        public void DeleteAuthor(int id)
        {
            Author authorToDelete = _context.Authors.SingleOrDefault(x => x.Id == id);
            _context.Authors.Remove(authorToDelete);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateAuthor(Author author)
        {
            Author authorToUpdate = _context.Authors.SingleOrDefault(x => x.Id == author.Id );
            authorToUpdate.LastName = author.LastName;
            _context.Entry(authorToUpdate).State = EntityState.Modified;
        }
        public void InsertAuthor(Author author)
        {
            _context.Authors.Add(author);
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}