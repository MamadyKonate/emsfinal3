using System.ComponentModel.DataAnnotations;

namespace emsfinal3.Models
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
    }
}
