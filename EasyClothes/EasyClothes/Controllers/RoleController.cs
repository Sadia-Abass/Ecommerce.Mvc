using Microsoft.AspNetCore.Mvc;

namespace EasyClothes.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
