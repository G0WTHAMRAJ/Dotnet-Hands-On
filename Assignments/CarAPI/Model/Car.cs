using System.ComponentModel.DataAnnotations;

namespace CarAPI.Model
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Brand{ get; set; }
        public int Rate{ get; set; }

    }
}
