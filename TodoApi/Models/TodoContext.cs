using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;

    public DbSet<Booking> Booking { get; set; } = default!;

    public DbSet<Concert> Concert { get; set; } = default!;

    public DbSet<Show> Show { get; set; } = default!;
}