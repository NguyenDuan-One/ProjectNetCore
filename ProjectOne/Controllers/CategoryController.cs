using Microsoft.AspNetCore.Mvc;
using ProjectOne.DataAccess.DTO;
using ProjectOne.DataAccess.IService;
using ProjectOne.DataAccess.Service;

namespace ProjectOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        ICategoryRepository _categoryService;
        ICategoryGenericReposetory _categoryGenericReposetory;
        public CategoryController(ICategoryRepository categoryService, ICategoryGenericReposetory categoryGenericReposetory)
        {
            _categoryService = categoryService;
            _categoryGenericReposetory = categoryGenericReposetory;
        }


        [HttpPost("GetAll")]
        public async Task<ActionResult> GetAll(CategoryRequestData categoryRequestData)
        {
            try
            {
                var data = new List<Category>();
                data = await _categoryService.GetAllCategory(categoryRequestData);
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching categories", ex);
            }
        }

        [HttpPost("GetAllGenderic")]
        public async Task<ActionResult> GetAllGenderic()
        {
            try
            {
                var data = new List<Category>();
                data = await _categoryGenericReposetory.GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching categories", ex);
            }
        }

        [HttpPost("InsertData")]
        public async Task<ActionResult> InsertData(CategoryInsertData requestData)
        {
            try
            {
                var rs = await _categoryService.InsertDataCategory(requestData);
                return Ok(rs);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
