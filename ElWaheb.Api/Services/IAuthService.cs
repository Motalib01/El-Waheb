using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Identity;
using ElWaheb.Api.RequestsResponses;

namespace ElWaheb.Api.Services
{
    public interface IAuthService
    {
        Task<AuthResponse?> LoginAsync(AuthRequest model);
        Task<IdentityResult> RegisterAsync(RequestsResponses.RegisterRequest model);
        Task<IdentityResult> UpdateProfileAsync(string userId, UpdateProfileRequest model);
        Task<GetUserRequestResponse?> GetUserByIdAsync(string userId);
        //TODO: Add ChangePasswordAsync method
        //Task<IdentityResult> ChangePasswordAsync(string userId, ChangePasswordRequest model);
    }
}
