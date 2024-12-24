using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface ITaskItemRepository : IGenericRepository<TaskItem>
    {
        Task<List<TaskItem>> GetTaskItemByTitleAsync(string title);
        Task<bool> IsTaskUnique(TaskItem entity);
    }
}
