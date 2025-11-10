using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace hali_takip.Models.Entities
{
    // IdentityDbContext miras alıyoruz ki Identity tabloları (AspNetUsers vs.) otomatik oluşsun
    public class HaliDbContext : IdentityDbContext<ApplicationUser>
    {
        public HaliDbContext(DbContextOptions<HaliDbContext> options)
            : base(options)
        {
        }

   
    }
}
