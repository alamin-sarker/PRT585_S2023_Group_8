using Microsoft.AspNetCore.Identity;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Services
{
    public interface IAuthService
    {
        string GenerateTokenString(LoginUser user);
        Task<bool> Login(LoginUser user);

        Task<bool> RegisterUser(LoginUser user);
    }
}