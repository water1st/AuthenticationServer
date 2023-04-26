using System.Threading.Tasks;

namespace AuthenticationServer.Core.Jwt
{
    public interface IJwtService
    {
        Task<string> CreateJwtAsync(JwtPayloadInfo payload);
    }
}
