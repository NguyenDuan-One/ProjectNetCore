using ProjectOne.DataAccess.DBContext;
using ProjectOne.DataAccess.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public DBContexts _dBContexts;
        public ICategoryGenericReposetory _categoryGenericReposetory { get; set; }
        public IAppInforGenericReponsetory _appInforGenericReposetory { get; set; }

        public UnitOfWork(DBContexts dBContext, ICategoryGenericReposetory categoryGenericReposetory,IAppInforGenericReponsetory appInforGenericReponsetory)
        {
            _dBContexts = dBContext;
            _categoryGenericReposetory = categoryGenericReposetory;
            _appInforGenericReposetory = appInforGenericReponsetory;
        }
        public void Dispose()
        {
            _dBContexts.Dispose();
        }

        public int SaveChanges()
        {
            return _dBContexts.SaveChanges();
        }
    }
}
