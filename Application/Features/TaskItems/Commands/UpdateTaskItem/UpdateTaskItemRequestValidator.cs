using Application.Features.TaskItems.Commands._Shared;
using FluentValidation;

namespace Application.Features.TaskItems.Commands.UpdateTaskItem
{
    public class UpdateTaskItemRequestValidator : AbstractValidator<UpdateTaskItemRequest>
    {
        public UpdateTaskItemRequestValidator()
        {
            RuleFor(t => t.Id)
                .NotNull().WithMessage("{PropertyName} is required.");

            Include(new BaseTaskItemRequestValidator());
        }
    }
}
