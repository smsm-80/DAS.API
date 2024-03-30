using DAS.Application.DTOs.Main.User;
using DAS.Application.Helpers.Model;
using DAS.Application.Interfaces.IServices.General;
using DAS.Application.Interfaces.IServices.Main.User;
using DAS.Application.Services.Main.User;
using DAS.Application.Wrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DAS.API.Controllers.Main
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SysUserController : Controller
    {
        // GET: SysUserController
        private readonly ISysUserService _Sys_UserService;
        private readonly ITokenService _tokenService;
        public SysUserController(ISysUserService sys_UserService, ITokenService tokenService)
        {
            _Sys_UserService = sys_UserService;
            _tokenService = tokenService;
        }

        // GET: SysUserController/GetAll
        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAll([FromBody] SysUserSearchDto SysUserSearch)
        {
            var request = SysUserSearch.ToRequestModel(Request);

            try
            {
                var sys_UserFromService = await _Sys_UserService.GetAll(request);
                return Ok(sys_UserFromService);
            }
            catch (Exception exp)
            {
                return Ok(await Result<object>.FailAsync($"EXP in {this.GetType()}, Meesage: {exp.Message} and {exp.InnerException.Message}"));
            }
        }

     
    }
}
