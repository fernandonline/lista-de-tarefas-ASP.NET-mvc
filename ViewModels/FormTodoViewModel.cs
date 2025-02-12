using System.ComponentModel.DataAnnotations;
namespace TodoList.ViewModels;
    
public class FormTodoViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O título da tarefa é obrigatório.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "A data é obrigatória.")]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; } = DateTime.Today;
}