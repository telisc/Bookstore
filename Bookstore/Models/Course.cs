using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.DAL
{
    public class Course  : IEntity
    {
        public Course()
        {
        }
        [Key]
        public int ID { get; set; }
        [Required]
        public string CourseName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}