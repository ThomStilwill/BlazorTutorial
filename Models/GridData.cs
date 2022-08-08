namespace BlazorTutorial.Models
{
    public class GridData<T> where T: IItem
    {
        public List<string> ColumnNames;
        public List<T> Items;

        public GridData()
        {
            ColumnNames = new List<string>();
            Items = new List<T>();
        }
    }
}
