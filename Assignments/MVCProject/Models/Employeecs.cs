using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Employeecs
    {
        [Key]
       public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [MaxLength(15)]
        public string? Department { get; set; }

        public int ? Salary { get; set; }
    }
}
