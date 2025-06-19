using Microsoft.EntityFrameworkCore;
using ProjectOne.DataAccess.DBContext;
using ProjectOne.DataAccess.DTO;
using ProjectOne.DataAccess.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.DataAccess.Service
{
    public class CategoryService : ICategoryService
    {
        DBContext.DBContexts _dBContext;
        public CategoryService(DBContext.DBContexts dBContext)
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
                    return lstCategory.Where(x => x.name.ToLower().Contains(categoryRequestData.Name.ToLower())).ToList();
                }
                else
                {
                    lstCategory = _dBContext.Categorys.ToList();
                    return lstCategory;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching categories", ex);
            }
        }
    }
}
