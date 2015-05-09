using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DAL
{
    interface IAuthorRepository :IDisposable 
    {
        IEnumerable<Author> GetAuthors();
        Author GetAuthorByID(int id);
        void InsertAuthor(Author author);
        void DeleteAuthor(int id);
        void UpdateAuthor(Author author);
        void Save();
    }
}
