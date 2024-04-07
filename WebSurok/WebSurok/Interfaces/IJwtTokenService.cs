using WebSurok.Data.Entities.Identity;

namespace WebSurok.Interfaces
{
    public interface IJwtTokenService
    {
        Task<string> CreateToken(UserEntity user);
    }
}
