using BlazorTutorial.Domain.Models;
using FluentValidation;

namespace BlazorTutorial.Domain.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleSet("Address", () =>
                {
                    RuleFor(x => x.NumberAndStreet).NotEmpty().WithMessage("Please specify a street address.");
                    RuleFor(x => x.City).NotEmpty().WithMessage("Please specify a city.");
                    RuleFor(x => x.State)
                        .NotEmpty().WithMessage("Please specify a valid state code.")
                        .MaximumLength(2).WithMessage("State codes are two letters")
                        .MinimumLength(2).WithMessage("State codes are two letters");
                    RuleFor(x => x.PostalCode).Must(BeAValidPostcode).WithMessage("Please specify a valid postcode.");
                }
            );
        }

        private bool BeAValidPostcode(string postcode)
        {
            return true;
            // custom postcode validating logic goes here
        }
    }
}
