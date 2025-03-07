using Microsoft.EntityFrameworkCore;

namespace ConsoleApp15;

public class ShopContext : DbContext
{
   public DbSet<Category> Categories { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer("Server=.;Database=ShopDb2;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var categories =new List<Category>();
        for (var i = 0; i < 100; i++)
        {
            
            categories.Add( new Category(){Id=i+1,Name = $"Category{i}"});
        }
        modelBuilder.Entity<Category>().HasData(categories);
    }
}