using Application.Contracts.Persistence;
using Application.Exceptions;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.TaskItems.Commands.CreateTaskItem
{
    public class CreateTaskItemRequestHandler : IRequestHandler<CreateTaskItemRequest, int>
    {
        private readonly IMapper _mapper;
        private readonly ITaskItemRepository _repository;

        public CreateTaskItemRequestHandler(IMapper mapper, ITaskItemRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<int> Handle(CreateTaskItemRequest request, CancellationToken cancellationToken)
        {
            // Validate the incoming data
            var validator = new CreateTaskItemRequestValidator(_mapper, _repository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.IsValid == false)
            {
                throw new BadRequestException("Something went wrong.", validationResult.ToDictionary());
            }

            // Convert to domain entity data
            var itemToAdd = _mapper.Map<TaskItem>(request);

            // Save to database
            await _repository.CreateAsync(itemToAdd);

            // Return the value
            return itemToAdd.Id;
        }
    }
}
