using ElWaheb.Api.RequestsResponses;
using ElWaheb.Api.Servises;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ElWaheb.Api.Controllers
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

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var result = await _authService.RegisterAsync(request);
            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("User registered successfully.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthRequest request)
        {
            var response = await _authService.LoginAsync(request);
            if (response == null)
                return Unauthorized("Invalid credentials");

            return Ok(response);
        }

        [HttpPut("update-profile")]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileRequest request)
        {
            if (!User.Identity.IsAuthenticated)
                return Unauthorized("User is not authenticated");

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;


            if (string.IsNullOrEmpty(userId))
                return Unauthorized("Invalid user");

            var result = await _authService.UpdateProfileAsync(userId, request);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("Profile updated successfully.");
        }
    }
}
