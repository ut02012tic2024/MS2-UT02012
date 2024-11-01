using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            _userService.Register(request);
            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var user = _userService.Authenticate(request.NIC, request.Password);
            if (user == null)
                return Unauthorized("Invalid credentials");

            return Ok(user);
        }
    }
}
