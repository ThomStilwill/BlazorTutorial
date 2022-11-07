using BlazorTutorial.Domain.Models;
using FluentValidation;

namespace BlazorTutorial.Domain.Validators
{
    public class ActivityValidator : AbstractValidator<Activity>
    {
        public ActivityValidator()
        {
            RuleSet("Activity", () =>
            {
                RuleFor(x => x.ActivityDate)
                    .NotEmpty();

                RuleFor(x => x.Description)
                    .NotEmpty();
            });
        }
    }
}
