using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationServer.Core.RsaKey
{
    internal interface IKeyReader
    {
        Task<byte[]> ReadAsync(string keys);
    }
}
