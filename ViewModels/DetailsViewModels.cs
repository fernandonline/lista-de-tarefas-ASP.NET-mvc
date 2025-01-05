using ToDoList.Models;
namespace TodoList.ViewModels;

public class DetailsViewModel
{
    public Todo Todo { get; set; } = null!;
    public string PageTitle { get; set; } = string.Empty;
}