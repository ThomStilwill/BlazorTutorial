
using BlazorTutorial.Models;

namespace BlazorTutorial.Pages
{
    public partial class Index
    {
        public string title = "Hello Worm!";
        private GridData<Item> Robins;

        protected override async Task OnInitializedAsync()
        {
            Robins = new GridData<Item>();

            Robins.Items = new List<Item>
            {
                new Item{LastName = "Todd", FirstName = "Jason", Street = "1600 Wayne Ln", City = "Gotham", State = "NY", Zip = "09007"},
                new Item{LastName = "Tim", FirstName = "Drake", Street = "1600 Wayne Ln", City = "Gotham", State = "NY", Zip = "09007"},
                new Item{LastName = "Dick", FirstName = "Grayson", Street = "1600 Wayne Ln", City = "Gotham", State = "NY", Zip = "09007"}
            };

            var columnNames = new string[] { "FirstName", "LastName","Street","City","State","Zip" };

            Robins.ColumnNames = columnNames.ToList();
        }
        
    }
}
