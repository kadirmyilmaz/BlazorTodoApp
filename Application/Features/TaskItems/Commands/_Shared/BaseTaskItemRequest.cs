namespace Application.Features.TaskItems.Commands._Shared
{
    public class BaseTaskItemRequest
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}