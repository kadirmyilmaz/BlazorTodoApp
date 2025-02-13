using Application.Features.TaskItems.Queries.GetAllTaskItems;

namespace WebUI.Services
{
    public interface ITaskItemDataService
    {
        Task<List<GetAllTaskItemsDto>> GetAllAsync();
    }
}
