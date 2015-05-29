using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Bookstore.DAL;
using Bookstore.Models;


namespace Bookstore.DAL
{
    public class CategoryContext : DbContext  
    {
        public CategoryContext() 
            :base("Name=BookStoreConnectionString")
        { 
        }
        public DbSet<Category> categories { get; set; }
    }
}