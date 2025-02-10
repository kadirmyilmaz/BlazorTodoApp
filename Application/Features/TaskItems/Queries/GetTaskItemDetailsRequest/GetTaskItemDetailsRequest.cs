using MediatR;

namespace Application.Features.TaskItems.Queries.GetTaskItemDetailsRequest
{
    public record GetTaskItemDetailsRequest(Guid Id) : IRequest<GetTaskItemDetailsDto>
    {
    }
}
