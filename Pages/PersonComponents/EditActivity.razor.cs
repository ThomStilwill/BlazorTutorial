using Microsoft.AspNetCore.Components;
using BlazorTutorial.Domain.Models;

namespace BlazorTutorial.Pages.PersonComponents
{
    public partial class EditActivity
    {
        [Parameter]
        public Person Person { get;set;}

        public Activity Activity { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Activity = Person.Activity;
        }
    }
}