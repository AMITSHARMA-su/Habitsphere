using System.ComponentModel.DataAnnotations;

namespace Habitsphere.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }

        public int ActivityId { get; set; }

        public DateTime Date { get; set; } = DateTime.Today;

        public bool Completed { get; set; }

        public Activity? Activity { get; set; }
    }
}