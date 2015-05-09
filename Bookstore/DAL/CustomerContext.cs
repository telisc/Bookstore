using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Bookstore.Models;

namespace Bookstore.DAL
{
    public class CustomerContext:DbContext
    {
        public CustomerContext()
            : base("name=BookStoreConnectionString")
        {           
        }

        public DbSet<Customer> Customers { get; set; }

    }
}