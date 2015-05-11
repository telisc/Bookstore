using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Bookstore.DAL;
using Bookstore.Models;

namespace Bookstore.DAL
{
    public class CourseContext :DbContext
    {
        public CourseContext()
            :base("name=BookStoreConnectionString")
        {

        }
        public DbSet<Course> Courses{ get; set; }
    }
}