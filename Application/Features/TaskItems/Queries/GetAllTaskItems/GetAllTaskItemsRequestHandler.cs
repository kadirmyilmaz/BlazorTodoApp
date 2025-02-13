using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.TaskItems.Queries.GetAllTaskItems
{
    public class GetAllTaskItemsRequestHandler : IRequestHandler<GetAllTaskItemsRequest, List<GetAllTaskItemsDto>>
    {
        private readonly IMapper _mapper;
        private readonly ITaskItemRepository _repository;

        public GetAllTaskItemsRequestHandler(IMapper mapper, ITaskItemRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<GetAllTaskItemsDto>> Handle(GetAllTaskItemsRequest request, CancellationToken cancellationToken)
        {
            var taskItems = await _repository.GetAllAsync();
            return _mapper.Map<List<GetAllTaskItemsDto>>(taskItems);
        }
    }
}
