using System.ComponentModel.DataAnnotations;

namespace DMSEntityFrameWork.Models
{
    public class Doctor
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public string qualification { get; set; }

        public string specialisation { get; set; }

       

    }
}
