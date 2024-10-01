using Microsoft.AspNetCore.Mvc;

namespace EasyClothes.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
