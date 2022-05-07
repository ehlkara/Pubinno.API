using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pubinno.BusinessLogic.Abstract.IUserBLL;
using Pubinno.Shared.PubinnoDTOs.PubinnoIdentity;
using Pubinno.Shared.Responses;
using System;
using System.Threading.Tasks;

namespace Pubinno.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserBLL _userBLL;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserBLL userBLL, ILogger<UsersController> logger)
        {
            _userBLL = userBLL;
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<Response<bool>> Register([FromBody] RegisterDto request)
        {
            try
            {
                var responseDto = await _userBLL.Register(request);
                return await Response<bool>.Run(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return await Response<bool>.Catch(new ResponseError { Messages = ex.Message });
            }
        }


        [HttpPost("login")]
        public async Task<Response<LoginResponseDto>> Login([FromBody] LoginDto request)
        {
            try
            {
                var responseDto = await _userBLL.Login(request);
                return await Response<LoginResponseDto>.Run(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return await Response<LoginResponseDto>.Catch(new ResponseError { Messages = ex.Message });
            }
        }

        [HttpPost("get_user_by_id")]
        public async Task<Response<UserDto>> GetUserById([FromBody] int id)
        {
            try
            {
                var responseDto = await _userBLL.GetUserById(id);
                return await Response<UserDto>.Run(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return await Response<UserDto>.Catch(new ResponseError { Messages = ex.Message });
            }

        }
    }
}
