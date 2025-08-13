using ProjectOne.DataAccess.DBContext;
using ProjectOne.DataAccess.DTO;
using ProjectOne.DataAccess.IService;

namespace ProjectOne.DataAccess.Service
{
    public class CategoryReposetory : ICategoryRepository
    {
        DBContexts _dBContext;
        public CategoryReposetory(DBContexts dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task<List<Category>> GetAllCategory(CategoryRequestData categoryRequestData)
        {
            try
            {
                var lstCategory = new List<Category>();
                if (!string.IsNullOrEmpty(categoryRequestData?.Name))
                {
                    lstCategory =  _dBContext.Category?.ToList();
                    return lstCategory.Where(x => x.name.ToLower().Contains(categoryRequestData.Name.ToLower())).ToList();
                }
                else
                {
                    // Fix for CS8604: Ensure _dBContext.Categorys is not null before calling ToList()  
                    lstCategory = _dBContext.Category?.ToList();
                    return lstCategory;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching categories", ex);
            }
        }

        public async Task<ReturnData> InsertDataCategory(CategoryInsertData categoryInsertData)
        {
            var returnData = new ReturnData();
            try
            {
                if(categoryInsertData==null || String.IsNullOrEmpty(categoryInsertData.name)){
                    returnData.ReturnCode = -1;
                    returnData.ReturnMessage = "Dữ liệu không hợp lệ!";
                    return await Task.FromResult(returnData);
                }

                var req = new Category()
                {
                    name = categoryInsertData.name,
                    is_delete = false,
                    create_date = DateTime.Now,
                    create_user="Fxhp60068"
                };

                _dBContext.Category.Add(req);
                var response=_dBContext.SaveChanges();//trả về số dòng được thay đổi
                if (response == 0)
                {
                    returnData.ReturnCode = -2;
                    returnData.ReturnMessage = "Thêm mới thất bại!";
                    return await Task.FromResult(returnData);
                }
                returnData.ReturnCode = 1;
                returnData.ReturnMessage = "Thêm mới thành công!";
                return await Task.FromResult(returnData);
            }
            catch(Exception ex)
            {
                returnData.ReturnCode = -99;
                returnData.ReturnMessage = ex.Message;
                return await Task.FromResult(returnData);
            }
           
        }
    }
}
