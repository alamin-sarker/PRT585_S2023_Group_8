using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;
using WebApplication3tierApp.Services;


namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUser user)
        {
            if (await _authService.Login(user))
            {
                var tokenString = _authService.GenerateTokenString(user);
                return Ok(tokenString);
            }
            return BadRequest();

        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(LoginUser user)
        {
            if (await _authService.RegisterUser(user))
            {
                return Ok("Successfully Done");
            }
            return BadRequest("Something went wrong");
        }

    }
}