using hali_takip.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace hali_takip.Controllers
{
    public class KoleksiyonController : Controller
    {
      HaliDbContext dbContext = new HaliDbContext();    

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult getir(string koleksiyon)
        {
            var urunler = dbContext.Urunler
                .Where(u => u.Koleksiyon.Ad == koleksiyon)
                .ToList();



            return View(urunler);
        }
    }
}
