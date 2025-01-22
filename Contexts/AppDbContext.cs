using Microsoft.EntityFrameworkCore;
using TodoList.EntityConfigs;
using ToDoList.Models;

namespace TodoList.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlite("Data Source=/app/publish/TodoList.db");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TodoEntity());
    }
}