using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using hali_takip;

namespace hali_takip.Models.Entities
{
    // IdentityDbContext miras alıyoruz ki Identity tabloları (AspNetUsers vs.) otomatik oluşsun
    public class HaliDbContext : DbContext
    {
     
        
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Koleksiyon> koleksiyonlar { get; set; }

         override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Bağlantı stringi
            optionsBuilder.UseSqlServer("Server=DESKTOP-8H6O6D1\\SQLEXPRESS;Database=HaliDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}
