using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace AuthenticationServer.Core.Jwt
{
    public class JwtPayloadInfo
    {
        /// <summary>
        /// Token的独立id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 颁发者
        /// </summary>
        public string Issuer { get; set; }
        /// <summary>
        /// 主题/被颁发对象（Userid)/ClientId
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 受众（校验Token的用户）
        /// </summary>
        public string Audience { get; set; }
        /// <summary>
        /// 启用时间
        /// </summary>
        public DateTimeOffset NotBefore { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTimeOffset ExpirationTime { get; set; }
        /// <summary>
        /// 签发时间
        /// </summary>
        public DateTimeOffset IssuedAt { get; set; }
        /// <summary>
        /// 其他Claims
        /// </summary>
        public Dictionary<string, string> OthersClaims { get; } = new Dictionary<string, string>();

        public void Verify()
        {
            if (Id == default)
                throw new ArgumentNullException(nameof(Id));

            if (Issuer == default)
                throw new ArgumentNullException(nameof(Issuer));

            if (Subject == default)
                throw new ArgumentNullException(nameof(Subject));

            if (Audience == default)
                throw new ArgumentNullException(nameof(Audience));

            if (NotBefore == default)
                throw new ArgumentNullException(nameof(NotBefore));

            if (ExpirationTime == default)
                throw new ArgumentNullException(nameof(ExpirationTime));

            if (IssuedAt == default)
                throw new ArgumentNullException(nameof(IssuedAt));
        }

        public static implicit operator JwtPayload(JwtPayloadInfo payload)
        {
            return new JwtPayload(payload.OthersClaims.Select(claim => new Claim(claim.Key, claim.Value)))
            {
                 //token id
                { JwtRegisteredClaimNames.Jti, payload.Id }, 
                //对象（token 的id对象）
                {JwtRegisteredClaimNames.Sub, payload.Subject },
                //受众（校验token的对象）
                { JwtRegisteredClaimNames.Aud, payload.Audience },
                //发行
                { JwtRegisteredClaimNames.Iss, payload.Issuer },
                ///签发时间
                { JwtRegisteredClaimNames.Iat, payload.IssuedAt.ToUnixTimeSeconds() },
                //生效时间
                { JwtRegisteredClaimNames.Nbf, payload.NotBefore.ToUnixTimeSeconds() },
                //过期时间
                { JwtRegisteredClaimNames.Exp, payload.ExpirationTime.ToUnixTimeSeconds() },
            };
        }
    }
}
