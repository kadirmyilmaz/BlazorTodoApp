﻿using Application.Features.TaskItems.Commands._Shared;
using MediatR;

namespace Application.Features.TaskItems.Commands.UpdateTaskItem
{
    public class UpdateTaskItemRequest : BaseTaskItemRequest, IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public DateTime? CompletedAt { get; set; }
    }
}
