using EasyClothes.Services.Interfaces;
using EasyClothes.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EasyClothes.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel categoryViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(categoryViewModel);
            }

            await _categoryRepository.AddAsync(categoryViewModel);

            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(long id) 
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            return View(category);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                await _categoryRepository.UpdateAsync(categoryViewModel);
                return RedirectToAction("Index", "Category");
            }

            return View(categoryViewModel);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
            await _categoryRepository.DeleteAsync(id);

            return RedirectToAction("Index", "Category");
        }
    }
}
