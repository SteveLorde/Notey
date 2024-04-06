using Microsoft.EntityFrameworkCore;

namespace Notey.App.Models;

public class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=databas.db");
    }
    
    public DbSet<Page> Pages { get; set; }
    
}