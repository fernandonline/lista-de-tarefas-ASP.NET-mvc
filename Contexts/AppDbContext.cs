using Microsoft.EntityFrameworkCore;
using TodoList.EntityConfigs;
using ToDoList.Models;


namespace TodoList.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseInMemoryDatabase("TodoListInMemoryDb");
}


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TodoEntity());
    }
}