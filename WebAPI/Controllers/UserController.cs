using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Shared;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserController(TokenService tokenService) : CustomControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Authenticated");

        [HttpPost]
        [Route("user-admin")]
        [AllowAnonymous]
        public async Task<IActionResult> UserAdmin()
        {
            var userAdmin = new User(
                name: "Admin",
                email: "admin@admin.com.br"
            );

            return Ok(tokenService.GenerateToken(userAdmin));
        }
    }
}
