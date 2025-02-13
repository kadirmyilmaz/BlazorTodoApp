namespace Application.Features.TaskItems.Queries.GetTaskItemDetailsRequest
{
    public class GetTaskItemDetailsDto
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}