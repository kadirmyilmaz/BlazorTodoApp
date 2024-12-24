using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class TaskItemDbContext(DbContextOptions<TaskItemDbContext> options) : DbContext(options)
    {
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}