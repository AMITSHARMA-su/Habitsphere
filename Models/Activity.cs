using System.ComponentModel.DataAnnotations;
namespace Habitsphere.Models
{
    public class Activity
    {
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        public string? Description { get; set; }
        public bool Completed { get; set; }
        public int Time { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public ICollection<ActivityLog> Logs { get; set; } = new List<ActivityLog>();
    }
}

