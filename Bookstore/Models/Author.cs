using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Column("DateOfBirth")]
        [Display(Name = "Date Of Birth")]
        public string DateOfBirth { get; set; }

    }
}