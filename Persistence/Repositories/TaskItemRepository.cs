using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class TaskItemRepository(TaskItemDbContext context) : GenericRepository<TaskItem>(context), ITaskItemRepository
    {
        public Task<List<TaskItem>> GetTaskItemByTitleAsync(string title)
        {
            return _dbSet.Where(t => t.Title == title).ToListAsync();
        }

        public async Task<bool> IsTaskUnique(TaskItem entity)
        {
            return await _dbSet.AnyAsync(t => 
            t.Title == entity.Title &&
            t.Description == entity.Description &&
            t.IsCompleted == entity.IsCompleted) == false;
        }
    }
}
