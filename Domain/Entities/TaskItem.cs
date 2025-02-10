using Domain.Common;

namespace Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        private string _title = string.Empty;
        public required string Title 
        { 
            get => _title; 
            set => _title = value ?? throw new ArgumentNullException(nameof(Title), "Title cannot be null."); 
        }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? CompletedAt { get; set; }

        public void MarkAsComplete()
        {
            if (IsCompleted)
            {
                // It is already completed, so throw domain-specific exception
                throw new InvalidOperationException($"'{Title}' has already been marked as complete.");
            }

            IsCompleted = true;
            CompletedAt = DateTime.UtcNow;
        }
    }
}
