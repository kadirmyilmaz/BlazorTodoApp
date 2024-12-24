using Application.Features.TaskItems.Commands._Shared;
using FluentValidation;

namespace Application.Features.TaskItems.Commands.UpdateTaskItem
{
    public class UpdateTaskItemRequestValidator : AbstractValidator<UpdateTaskItemRequest>
    {
        public UpdateTaskItemRequestValidator()
        {
            RuleFor(t => t.Id)
                .GreaterThanOrEqualTo(1);

            Include(new BaseTaskItemRequestValidator());
        }
    }
}
