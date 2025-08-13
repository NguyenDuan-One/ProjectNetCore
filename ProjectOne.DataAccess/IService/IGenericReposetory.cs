using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.DataAccess.IService
{
    public interface IGenericReposetory<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<int> Insert(T entity);
    }
}
