using BlazorTutorial.Domain.Models;
using FluentValidation;

namespace BlazorTutorial.Domain.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleSet("Person", () =>
            {
                RuleFor(x => x.LastName).NotEmpty().WithMessage("Please specify a last name.");
                RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please specify a first name.");
                RuleFor(x => x.StartDate).NotEmpty().WithMessage("Please specify a start date.");

                RuleFor(x => x.Address).SetValidator(new AddressValidator());
                RuleFor(x => x.Activity).SetValidator(new ActivityValidator());
            });
        }
    }
}
