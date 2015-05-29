using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Bookstore.DAL;

namespace Bookstore.Models
{
    public class Category : IEntity
    {
        public Category()
        {
        }
        [Key]
        public int CategoryID {get;set;}
        public String CategoryName { get; set; }
        public String Description { get; set; }
    }
}