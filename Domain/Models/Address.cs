using System.ComponentModel.DataAnnotations;

namespace BlazorTutorial.Domain.Models
{
    public class Address
    {
        public string NumberAndStreet { get; set; }
        public string City { get; set; }
        
        [MaxLength(2,ErrorMessage ="Use a state abbreviation.")]
        public string State { get; set; }

        public string PostalCode { get; set; }
    }
}
