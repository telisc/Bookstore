using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Bookstore.DAL
{
    public class StudentContext : DbContext
    {
        public StudentContext()
            :base("Name=BookStoreConnectionString")
        {
            
        }
        public DbSet<Student> Students { get; set;}
    }
}