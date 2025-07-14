

namespace ProjectOne.DataAccess.IService
{
    public interface IAppInfor
    {
        public Task<List<DTO.AppInfor>> GetAllAppInfor();
    }
}
