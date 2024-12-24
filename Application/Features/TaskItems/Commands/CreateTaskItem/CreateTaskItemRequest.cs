using Application.Features.TaskItems.Commands._Shared;
using MediatR;

namespace Application.Features.TaskItems.Commands.CreateTaskItem
{
    public class CreateTaskItemRequest : BaseTaskItemRequest, IRequest<int>
    {
    }
}