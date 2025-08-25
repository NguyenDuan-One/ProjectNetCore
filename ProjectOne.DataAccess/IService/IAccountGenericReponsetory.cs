using ProjectOne.DataAccess.DTO;

namespace ProjectOne.DataAccess.IService
{
    public interface IAccountGenericReponsetory:IGenericReposetory<DTO.AccountDTO>
    {
        Task<ReturnData> AccountLogin(AccountLoginRequestData accountRequestData);
    }
}
