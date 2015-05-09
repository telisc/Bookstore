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
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String DateOfBirth { get; set; }
        public String City { get; set; }
    }
}