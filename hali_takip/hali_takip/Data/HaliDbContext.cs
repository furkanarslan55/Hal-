using Microsoft.EntityFrameworkCore;
using hali_takip.Models.Entities;



namespace hali_takip.Data;



public class HaliDbContext: DbContext

{
   public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=FURKANARSLAN\\SQLEXPRESS;Database=HaliDb;Trusted_Connection=True;MultipleActiveResultSets=true");
    }


}
