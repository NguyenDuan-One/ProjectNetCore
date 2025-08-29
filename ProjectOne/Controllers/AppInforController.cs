using Microsoft.AspNetCore.Mvc;
using ProjectOne.DataAccess.DTO;
using ProjectOne.DataAccess.IService;
using ProjectOne.DataAccess.UnitOfWork;


namespace ProjectOne.Controllers
{
    public class AppInforController : Controller
    {
        IAppInforGenericReponsetory _appInforGenericReponsetory;
   
        IUnitOfWork _unitOfWork;
        public AppInforController(IAppInforGenericReponsetory appInforGenericReponsetory,
                                  IUnitOfWork unitOfWork)
        {
            _appInforGenericReponsetory = appInforGenericReponsetory;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var dt = await _appInforGenericReponsetory.GetAll();
                return Ok(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("InsertData")]
        public async Task<IActionResult> InsertData()
        {
            try
            {
                //Su dung UnitOfWork
                var appInfor = new AppInfor()
                {
                    name = "ProjectOne",
                    link="Tesst",
                    status="False",
                    version = "1.0.0",
                    is_delete = false,
                    create_user = "Fxhp60068",
                    update_user = "Fxhp60068",
                    create_date = DateTime.Now,
                    update_date = DateTime.Now
                };

                var category = new Category()
                {
                    name = "Category 1",
                    is_delete = false,
                    create_date = DateTime.Now,
                    create_user = "Fxhp60068"
                };

                await _unitOfWork._categoryGenericReposetory.Insert(category);
                await _unitOfWork._appInforGenericReposetory.Insert(appInfor);

                _unitOfWork.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.Message ?? ex.Message;
                return BadRequest($"Lỗi: {inner}");
            }
        }
    }
}
