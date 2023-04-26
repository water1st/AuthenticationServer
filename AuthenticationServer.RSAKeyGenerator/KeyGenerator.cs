using System;
using System.Security.Cryptography;
using System.Text;

namespace AuthenticationServer.RSAKeyGenerator
{
    public static class KeyGenerator
    {
        public static Key Generate()
        {
            using (var rsa = RSA.Create())
            {
                var privateKey = rsa.ExportRSAPrivateKey();
                var publicKey = rsa.ExportRSAPublicKey();

                var privateKeyContent = BuildKeyFileContent(privateKey, false);
                var publicKeyContent = BuildKeyFileContent(publicKey, true);

                return new Key
                {
                    PublicKey = publicKeyContent,
                    PrivateKey = privateKeyContent
                };
            }
        }

        private static string BuildKeyFileContent(byte[] key, bool isPublic)
        {
            var builder = new StringBuilder();
            var content = Convert.ToBase64String(key);
            const string @public = "PUBLIC";
            const string @private = "PRIVATE";
            const string _ = "-----";
            builder.AppendLine($"{_}BEGIN RSA {(isPublic ? @public : @private)} KEY{_}");

            for (int i = 0; i < content.Length; i++)
            {
                var current = content[i];
                if ((i % 64 == 0 && i > 0) || i == content.Length - 1)
                {
                    builder.AppendLine(current.ToString());
                }
                else
                {
                    builder.Append(current);
                }
            }

            builder.Append($"{_}END RSA {(isPublic ? @public : @private)} KEY{_}");

            return builder.ToString();
        }
    }
}
