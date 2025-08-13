using Microsoft.EntityFrameworkCore;
using ProjectOne.DataAccess.DBContext;
using ProjectOne.DataAccess.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.DataAccess.Service
{
    public class GenericReposetory<T> : IGenericReposetory<T> where T : class
    {
        DBContexts _dBContext;
        public GenericReposetory(DBContexts dbContexts) {
            _dBContext = dbContexts;
        }

        public async Task<List<T>> GetAll()
        {
            return _dBContext.Set<T>().ToList();
        }

        public Task<int> Insert(T entity)
        {
             _dBContext.Add(entity);
            return _dBContext.SaveChangesAsync();
        }
    }
}
