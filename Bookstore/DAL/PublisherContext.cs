using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Bookstore.Models;

namespace Bookstore.DAL
{
    public class PublisherContext:DbContext 
    {
        public PublisherContext()
            : base("name=BookStoreConnectionString")
        {

        }
        public DbSet<Publisher> Publishers { get; set; }
    }
}