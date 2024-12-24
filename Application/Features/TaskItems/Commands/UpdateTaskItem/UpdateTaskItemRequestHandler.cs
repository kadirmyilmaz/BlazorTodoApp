using Application.Contracts.Persistence;
using Application.Exceptions;
using AutoMapper;
using MediatR;

namespace Application.Features.TaskItems.Commands.UpdateTaskItem
{
    public class UpdateTaskItemRequestHandler : IRequestHandler<UpdateTaskItemRequest, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ITaskItemRepository _repository;

        public UpdateTaskItemRequestHandler(IMapper mapper, ITaskItemRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateTaskItemRequest request, CancellationToken cancellationToken)
        {
            var validator = new UpdateTaskItemRequestValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Something went wrong", validationResult.ToDictionary());
            }

            // Retrieve domain entity object
            var entity = await _repository.GetByIdAsync(request.Id);

            if (entity is null)
                throw new NotFoundException(nameof(entity), request.Id.ToString());

            // Map to domain entity data
            _mapper.Map(request, entity);

            // Save changes to database
            await _repository.UpdateAsync(entity);

            // Return the value
            return Unit.Value;
        }
    }
}