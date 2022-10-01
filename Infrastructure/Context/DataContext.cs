using Microsoft.EntityFrameworkCore;
using Domain.Entities;
namespace Infrastructure.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Quote> Quotes { get; set; }
    public DbSet<Category> Categories { get; set; }
}
