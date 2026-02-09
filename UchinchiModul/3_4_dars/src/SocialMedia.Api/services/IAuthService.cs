using SocialMedia.Api.Dtos;

namespace SocialMedia.Api.services
{
    public interface IAuthService
    {
        public Guid RegisterUser(UserRegisterDto userRegisterDto);
        public string LoginUser(UserLoginDto userLoginDto);
    }
}