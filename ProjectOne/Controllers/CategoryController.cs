using Microsoft.AspNetCore.Mvc;
using ProjectOne.DataAccess.DTO;
using ProjectOne.DataAccess.IService;

namespace ProjectOne.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService) {
            _categoryService = categoryService;
        }
        public Task<List<Category>> Index(CategoryRequestData categoryRequestData)
        {
            try
            {
                return _categoryService.GetAllCategory(categoryRequestData);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching categories", ex);
            }

        }
    }
}
