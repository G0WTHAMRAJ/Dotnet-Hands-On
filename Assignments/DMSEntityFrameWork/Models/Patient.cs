using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMSEntityFrameWork.Models
{
    public class Patient
    {
        [Key]
        
        public int pId { get; set; }
        [DisplayName("Patient Name")]
        public string? pName { get; set; }
        [DisplayName("Disease")]
        public string? pDisease { get; set; }

        [ForeignKey("Doctor")]
        [DisplayName("Doctor Id")]
        public int? id { get; set; }

        
        


    }
}
