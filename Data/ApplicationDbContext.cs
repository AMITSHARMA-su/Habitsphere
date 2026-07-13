using Microsoft.EntityFrameworkCore;
using Habitsphere.Models;
namespace Habitsphere.Data
{
      public class ApplicationDbContext : DbContext
      {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
            {
            }
       public DbSet<Activity> Activities { get; set; }
       public DbSet<ActivityLog> ActivityLogs { get; set; }
    }

}
