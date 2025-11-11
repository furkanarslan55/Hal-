using hali_takip.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using hali_takip;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace hali_takip.Controllers
{



    public class MarkaController : Controller
    {
        HaliDbContext dbContext = new HaliDbContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Getir(string marka)
        {
            var secilenMarka = await dbContext.Markalar
            .Include(m => m.Koleksiyonlar) 
            .FirstOrDefaultAsync(m => m.Ad == marka);

            return View(secilenMarka);
        }


    }
}
