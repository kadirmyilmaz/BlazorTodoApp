using Application.Contracts.Persistence;
using Application.Features.TaskItems.Commands._Shared;
using AutoMapper;
using Domain.Entities;
using FluentValidation;

namespace Application.Features.TaskItems.Commands.CreateTaskItem
{
    public class CreateTaskItemRequestValidator : AbstractValidator<CreateTaskItemRequest>
    {
        private IMapper _mapper;
        private ITaskItemRepository _repository;

        public CreateTaskItemRequestValidator(IMapper mapper, ITaskItemRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

            Include(new BaseTaskItemRequestValidator());

            RuleFor(t => t)
                .MustAsync(UniqueTask).WithMessage("The specified task item already exists.");
        }

        private async Task<bool> UniqueTask(CreateTaskItemRequest request, CancellationToken token)
        {
            var entity = _mapper.Map<TaskItem>(request);
            return await _repository.IsTaskUnique(entity);
        }
    }
}
