namespace Application.Features.TaskItems.Commands._Shared
{
    public class BaseTaskItemRequest
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}