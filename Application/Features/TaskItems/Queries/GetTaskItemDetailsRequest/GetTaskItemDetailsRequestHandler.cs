using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.TaskItems.Queries.GetTaskItemDetailsRequest
{
    public class GetTaskItemDetailsRequestHandler : IRequestHandler<GetTaskItemDetailsRequest, GetTaskItemDetailsDto>
    {
        private readonly ITaskItemRepository _repository;
        private readonly IMapper _mapper;

        public GetTaskItemDetailsRequestHandler(IMapper mapper, ITaskItemRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<GetTaskItemDetailsDto> Handle(GetTaskItemDetailsRequest request, CancellationToken cancellationToken)
        {
            // Query the database
            var entity = await _repository.GetByIdAsync(request.Id);

            var result = _mapper.Map<GetTaskItemDetailsDto>(entity);

            return result;
        }
    }
}
