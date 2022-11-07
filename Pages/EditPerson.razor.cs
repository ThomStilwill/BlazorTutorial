using Blazored.FluentValidation;
using BlazorTutorial.Domain.Models;
using BlazorTutorial.Models;

namespace BlazorTutorial.Pages
{
    public partial class EditPerson
    {
        private string title ="Edit Person";

        private Person person = new();
        private FluentValidationValidator? validator;

        private void OnSubmit()
            => Console.WriteLine("Form Submitted Successfully!");

        private void PartialValidate()
        {
            var isValid = validator?.Validate(options => options.IncludeRuleSets("Person"));
            Console.WriteLine($"Partial validation result : {isValid}");
        }
    }
}
