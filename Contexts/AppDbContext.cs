using Microsoft.EntityFrameworkCore;
using TodoList.EntityConfigs;
using ToDoList.Models;

namespace TodoList.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        var connectionString = "Data Source=Data/TodoList.db";
        builder.UseSqlite(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TodoEntity());
    }
}