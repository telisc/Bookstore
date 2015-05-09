using System.Data.Entity;
using Bookstore.Models;

namespace Bookstore.DAL
{
    public class AuthorContext : DbContext
    {
        public AuthorContext()
            : base("name=BookStoreConnectionString")
        {           
        }

        public DbSet<Author> Authors { get; set; }

    }
}