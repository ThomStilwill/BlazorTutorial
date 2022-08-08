namespace BlazorTutorial.Models;

public interface IItem
{
    object this[string propertyName] { get; set; }
}