using IdentityModel.Client;

namespace tiendung99.IdentityServer.MVC.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
