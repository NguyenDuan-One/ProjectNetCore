using ProjectOne.DataAccess.DTO;

namespace ProjectOne.DataAccess.IService
{
    public interface IAccountService
    {
        Task<ReturnData> AccountLogin(AccountLoginRequestData accountRequestData);
    }
}
