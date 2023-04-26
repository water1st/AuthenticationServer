using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationServer.Core.RsaKey
{
    internal class KeyReader : IKeyReader
    {
        public async Task<byte[]> ReadAsync(string keys)
        {
            var stringBuilder = new StringBuilder();
            using (var reader = new StringReader(keys))
            {

                for (var line = await reader.ReadLineAsync(); line != null; line = await reader.ReadLineAsync())
                {
                    if (line.IndexOf("KEY") >= 0)
                        continue;

                    stringBuilder.Append(line);
                }
            }

            var key = stringBuilder.ToString();
            return Convert.FromBase64String(key);
        }


    }
}
