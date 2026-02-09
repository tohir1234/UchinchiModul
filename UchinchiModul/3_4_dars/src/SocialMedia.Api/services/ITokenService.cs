namespace SocialMedia.Api.services
{
    public interface ITokenService
    {
        public (string userId, string role) GetTokenInfo(string token);
    }
}