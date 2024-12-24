using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Features.TaskItems.Queries.GetAllTaskItems
{
    public class GetAllTaskItemsDto : IMapFrom<TaskItem>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}