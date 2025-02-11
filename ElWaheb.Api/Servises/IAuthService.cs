using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Identity;
using ElWaheb.Api.RequestsResponses;

namespace ElWaheb.Api.Servises
{
    public interface IAuthService
    {
        Task<AuthResponse?> LoginAsync(AuthRequest model);
        Task<IdentityResult> RegisterAsync(RequestsResponses.RegisterRequest model);
    }
}
