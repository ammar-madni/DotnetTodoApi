namespace DotnetTodoApi.Data;

using Microsoft.EntityFrameworkCore;
using Models;

public class DataContext : DbContext
{
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // => optionsBuilder.UseNpgsql(@"Host=localhost;Username=ammar;Database=dotnet-todo");

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Todo> Todos { get; set; }
}
