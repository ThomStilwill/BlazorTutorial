using System.ComponentModel.DataAnnotations;
namespace BlazorTutorial.Domain.Models
{
    public class Person
    {

        public Person()
        {
            Address = new();
            Activity = new();
        }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleInitial { get; set; }

        public string Note { get; set; }

        public DateTime StartDate { get; set; }
        

        [Required]
        public string Phone { get; set; }

        public bool UseAddress
        {
            get => Address != null;
            set => Address = value ? new() : null; 
        }

        public Address Address { get; set; }

        public bool UseActivity
        {
            get => Activity != null;
            set => Activity = value ? new() : null; 
        }

        public Activity Activity { get; set; }

    }
}
