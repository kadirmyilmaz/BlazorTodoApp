using FluentValidation;

namespace Application.Features.TaskItems.Commands._Shared
{
    public class BaseTaskItemRequestValidator : AbstractValidator<BaseTaskItemRequest>
    {
        public BaseTaskItemRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");

            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
