using Microsoft.AspNetCore.Mvc;

namespace EasyClothes.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
