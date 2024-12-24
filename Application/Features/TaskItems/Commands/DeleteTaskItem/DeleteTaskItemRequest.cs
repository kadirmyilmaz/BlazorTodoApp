using MediatR;

namespace Application.Features.TaskItems.Commands.DeleteTaskItem
{
    public record DeleteTaskItemRequest(int Id) : IRequest<Unit>;
}
