using ProjectOne.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.DataAccess.IService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategory(CategoryRequestData categoryRequestData);
    }
}
