using Microsoft.AspNetCore.Mvc;

namespace EasyClothes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
