using ProjectOne.DTO;

namespace ProjectOne.IService
{
    public interface IAccountService
    {
        Task<ReturnData> AccountLogin(AccountLoginRequestData accountRequestData);
    }
}
