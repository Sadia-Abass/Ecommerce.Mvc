using Microsoft.AspNetCore.Mvc;

namespace EasyClothes.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
