using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectOne.DataAccess.DTO;
using ProjectOne.DataAccess.IService;

namespace ProjectOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountGenericReponsetory _accountService;
        public AccountController(IAccountGenericReponsetory accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("AccountLogin")]
        public async Task<ActionResult> AccountLogin(AccountLoginRequestData accountLogin)
        {
            var returnData = new ReturnData();
            try
            {
                returnData=await _accountService.AccountLogin(accountLogin);
                return Ok(returnData);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
