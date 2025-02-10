using MediatR;

namespace Application.Features.TaskItems.Commands.DeleteTaskItem
{
    public record DeleteTaskItemRequest(Guid Id) : IRequest<Unit>;
}
