﻿using Domain.Common;

namespace Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
