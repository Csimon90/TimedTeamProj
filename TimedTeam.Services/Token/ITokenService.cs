using TimedTeam.Models.Token;

namespace TimedTeam.Services.Token
{
    public interface ITokenService
    {
        Task<TokenResponse> GetTokenAsync(TokenRequest model);
    }
}