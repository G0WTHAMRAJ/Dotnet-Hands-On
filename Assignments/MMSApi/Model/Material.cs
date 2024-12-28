using System.ComponentModel.DataAnnotations;

namespace MMSApi.Model
{
    public class Material
    {
        [Key]
        public int mId {  get; set; }
        [Required]
        public string? mName {  get; set; }
        [Required]
        public string? mType {  get; set; }
        public int mQuantity {  get; set; }
        public string? mRetailer {  get; set; }
    }
}
