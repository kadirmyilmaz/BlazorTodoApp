using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class TaskItemDbContext : DbContext
    {
        public TaskItemDbContext(DbContextOptions<TaskItemDbContext> options) : base(options)
        {
        }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}