using Microsoft.AspNetCore.Mvc;

namespace EasyClothes.Controllers
{
    public class OrderItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
