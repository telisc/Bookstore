using System.Data.Entity;
using Bookstore.Models;

namespace Bookstore.DAL
{
    public class BookContext :DbContext
    {
        public BookContext()
            : base("name=BookStoreConnectionString")
        {           
        }

        public DbSet<Book> Books { get; set; }
    }
}