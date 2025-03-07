using Microsoft.EntityFrameworkCore;

namespace ConsoleApp15;

public class ShopContext : DbContext
{
   public DbSet<Category> Categories { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer("Server=.;Database=ShopDb2;Trusted_Connection=True;TrustServerCertificate=True");
    }
}