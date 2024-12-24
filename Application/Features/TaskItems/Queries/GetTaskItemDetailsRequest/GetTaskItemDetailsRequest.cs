using MediatR;

namespace Application.Features.TaskItems.Queries.GetTaskItemDetailsRequest
{
    public record GetTaskItemDetailsRequest(int Id) : IRequest<GetTaskItemDetailsDto>
    {
    }
}
