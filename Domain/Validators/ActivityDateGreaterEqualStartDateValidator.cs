// using BlazorTutorial.Domain.Models;
// using FluentValidation;
// using FluentValidation.Validators;
//
// namespace BlazorTutorial.Domain.Validators
// {
//     public class ActivityDateGreaterEqualStartDateValidator<T,TProperty> : PropertyValidator<T, TProperty>
//     {
//         public override string Name => "NotNullValidator";
//
//         public override bool IsValid(ValidationContext<T> context, TProperty value)
//         {
//             var person = context InstanceToValidate as Person;
//             var targetDate = DateTime.Now;
//             return person != null && person.StartDate <= targetDate;
//         }
//
//         protected override string GetDefaultMessageTemplate(string errorCode)
//             => "A value for {PropertyName} is required";
//     }
//
// }
