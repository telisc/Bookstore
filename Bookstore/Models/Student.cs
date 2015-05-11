using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.DAL
{
    public class Student  :IEntity 
    {
        public Student() { }
        [Key]
        public int ID { get; set; }
        [Required]
        public string StudentName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}