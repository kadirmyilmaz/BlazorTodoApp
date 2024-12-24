﻿using Application.Features.TaskItems.Commands._Shared;
using MediatR;

namespace Application.Features.TaskItems.Commands.UpdateTaskItem
{
    public class UpdateTaskItemRequest : BaseTaskItemRequest, IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
