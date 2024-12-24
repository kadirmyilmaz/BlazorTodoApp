using Application.Contracts.Persistence;
using Application.Exceptions;
using Domain.Entities;
using MediatR;

namespace Application.Features.TaskItems.Commands.DeleteTaskItem
{
    public class DeleteTaskItemRequestHandler : IRequestHandler<DeleteTaskItemRequest, Unit>
    {
        private readonly ITaskItemRepository _repository;

        public DeleteTaskItemRequestHandler(ITaskItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteTaskItemRequest request, CancellationToken cancellationToken)
        {
            // Retrieve domain entity object
            var entity = await _repository.GetByIdAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(entity), request.Id.ToString());
            }

            // Remove from database
            await _repository.DeleteAsync(entity);

            // Return the value
            return Unit.Value;
        }
    }
}
