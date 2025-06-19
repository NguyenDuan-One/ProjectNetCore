using Microsoft.AspNetCore.Mvc;
using ProjectOne.DataAccess.DTO;
using ProjectOne.DataAccess.IService;

namespace ProjectOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService) {
            _categoryService = categoryService;
        }
        [HttpPost]
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
