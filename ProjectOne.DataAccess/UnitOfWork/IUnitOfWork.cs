using ProjectOne.DataAccess.IService;

namespace ProjectOne.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ICategoryGenericReposetory _categoryGenericReposetory { get; set; }
        public IAppInforGenericReponsetory _appInforGenericReposetory { get; set; }
        public int SaveChanges();
    }
}
