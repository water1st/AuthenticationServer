using AuthenticationServer.Core.RsaKey;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace AuthenticationServer.Core.Jwt
{
    internal class JwtService : IJwtService
    {
        private readonly IKeyLoader keyLoader;
        private readonly JwtSecurityTokenHandler tokenHandler;

        public JwtService(IKeyLoader keyLoader, JwtSecurityTokenHandler tokenHandler)
        {
            this.keyLoader = keyLoader;
            this.tokenHandler = tokenHandler;
        }

        public async Task<string> CreateJwtAsync(JwtPayloadInfo payload)
        {
            //校验
            payload.Verify();

            //私钥
            var privateKey = await keyLoader.LoadAsync();

            //签名证书
            var signingCredentials = new SigningCredentials(
                privateKey,
                SecurityAlgorithms.RsaSha256);

            var header = new JwtHeader(signingCredentials);
            var token = new JwtSecurityToken(header, payload);

            var jwt = tokenHandler.WriteToken(token);

            return jwt;
        }
    }
}
