using Application.Features.TaskItems.Queries.GetAllTaskItems;
using System.Net.Http.Json;

namespace WebUI.Services
{
    public class TaskItemDataService : ITaskItemDataService
    {
        private readonly HttpClient _httpClient;

        public TaskItemDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<GetAllTaskItemsDto>> GetAllAsync()
        {
            var items = await _httpClient.GetFromJsonAsync<List<GetAllTaskItemsDto>>("api/task");
            return items ?? new List<GetAllTaskItemsDto>();
        }
    }
}
