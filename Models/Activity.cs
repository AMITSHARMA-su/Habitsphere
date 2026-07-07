using System.ComponentModel.DataAnnotations;
namespace Habitsphere.Models
{
    public class Activity
    {
        public int Id { get; set; }
        [Required]
        public int Titile { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public int TimeSpentMinutes { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
