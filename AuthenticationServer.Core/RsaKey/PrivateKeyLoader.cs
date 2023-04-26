using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AuthenticationServer.Core.RsaKey
{
    internal class PrivateKeyLoader : IKeyLoader
    {
        private readonly IOptions<KeyLoaderOptions> options;
        private readonly IKeyReader reader;

        public PrivateKeyLoader(IOptions<KeyLoaderOptions> options, IKeyReader reader)
        {
            this.options = options;
            this.reader = reader;
        }
        public async Task<RsaSecurityKey> LoadAsync()
        {
            var keyText = options?.Value?.Key;
            if (string.IsNullOrWhiteSpace(keyText))
                throw new Exception("无法加载Key,请确认KeyLoaderOptions.Key已被赋值");

            var key = await reader.ReadAsync(keyText);

            var rsa = RSA.Create();
            rsa.ImportRSAPrivateKey(key, out var _);

            var result = new RsaSecurityKey(rsa);
            return result;
        }
    }
}
