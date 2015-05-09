using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookstore.Models;
using Bookstore.DAL;
using System.Data.Entity;

namespace Bookstore.App_Start
{
    public class DBInitializer
    {
        public class SchoolInitializer : DropCreateDatabaseIfModelChanges<AuthorContext>
        {
            
        }
    }
}