using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; } = "";

        public int ContactNumber { get; set; }
        public int Age { get; set; }
      
    }
}
