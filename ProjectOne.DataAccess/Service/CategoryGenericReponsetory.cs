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
    public class CategoryGenericReponsetory : GenericReposetory<Category>, ICategoryGenericReposetory
    {
        public CategoryGenericReponsetory(DBContexts dbContexts) : base(dbContexts)
        {
        }
    }

    
}
