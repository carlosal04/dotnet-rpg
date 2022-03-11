using DOTNET_RPG.Data;
using DOTNET_RPG.Dtos.User;
using DOTNET_RPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepository.Register(new User { UserName = request.UserName }, request.Password);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);

        }
        
        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepository.Login(request.UserName, request.Password);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);

        }
    }
}