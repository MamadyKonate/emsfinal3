using System.ComponentModel.DataAnnotations;

namespace emsfinal3.Models
{
    public class Credentials
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserEmail { get; set; } = "";
        [Required]
        public string EncPass { get; set; } = "";
    }
}
