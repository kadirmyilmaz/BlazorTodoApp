using MediatR;

namespace Application.Features.TaskItems.Queries.GetAllTaskItems
{
    public record GetAllTaskItemsRequest : IRequest<List<GetAllTaskItemsDto>>;
}
