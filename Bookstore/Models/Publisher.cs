using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Publisher
    {
        [Key]
        public int id { get; set; }
        [MaxLength(100), Required, Display(Name = "Publisher Name")]
        public string Name { get; set; }
    }
}