using BlazorTutorial.Domain.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorTutorial.Pages.PersonComponents

{
    public partial class EditAddress
    {
        [Parameter]
        public Person Person { get;set;}

        public Address Address { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Address = Person.Address;
        }
    }
}