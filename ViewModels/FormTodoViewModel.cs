using System.ComponentModel.DataAnnotations;

namespace TodoList.ViewModels;

public class FormTodoViewModel
{
    [Required(ErrorMessage = "O título da tarefa é obrigatório.")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "A data é obrigatória.")]
    public DateTime Date { get; set; }
}