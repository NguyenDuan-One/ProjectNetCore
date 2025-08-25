using ProjectOne.DataAccess.DBContext;
using ProjectOne.DataAccess.DTO;
using ProjectOne.DataAccess.IService;

namespace ProjectOne.DataAccess.Service
{
    public class AccountGenericReponsetory : GenericReposetory<AccountDTO>, IAccountGenericReponsetory
    {
        public AccountGenericReponsetory(DBContexts dbContexts) : base(dbContexts)
        {
        }

        public async Task<ReturnData> AccountLogin(AccountLoginRequestData accountRequestData)
        {
            try
            {
                ReturnData returnData = new ReturnData();
                if (accountRequestData == null || String.IsNullOrEmpty(accountRequestData.UserName)|| String.IsNullOrEmpty(accountRequestData.Password)) {
                    returnData.ReturnCode = -1;
                    returnData.ReturnMessage = "Dữ liệu request không hợp lệ! Kiểm tra lại!";
                    return returnData;
                }
                await Task.Yield();// skip async await
                returnData.ReturnCode = -1;
                returnData.ReturnMessage = "Đăng nhập thành công! Chúc mừng bạn!";
                return returnData;

            }
            catch (Exception ex) {
                throw new NotImplementedException(ex.Message);
            }
        }
    }
}
