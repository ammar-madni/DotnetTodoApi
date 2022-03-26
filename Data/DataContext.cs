namespace DotnetTodoApi.Data;

using Microsoft.EntityFrameworkCore;
using Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Todo> Todos { get; set; }
}
