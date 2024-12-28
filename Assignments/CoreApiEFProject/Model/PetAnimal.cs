using System.ComponentModel.DataAnnotations;

namespace CoreApiEFProject.Model
{
    public class PetAnimal
    {
        [Key]
        public int petId {  get; set; }
        [Required]
        public string? petName { get; set; }
        public string? petType { get; set; }
        public string? petDob { get;set; }
        public bool petIsVeg {  get; set; }
    }
}
