using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookstore.DAL;
using System.ComponentModel.DataAnnotations;
namespace Bookstore.Models
{
    public class Customer:IEntity 
    {
        [Key]
        public String CustomerID { get; set; }

        [Required]
        [MaxLength(50)]
        public String ContactName { get; set; }
        public String ContactTitle { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
    }
}