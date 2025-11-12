using Microsoft.AspNetCore.Mvc;

namespace hali_takip.Controllers
{
    public class BizKimizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
