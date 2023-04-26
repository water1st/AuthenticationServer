using Microsoft.IdentityModel.Tokens;
using System.Threading.Tasks;

namespace AuthenticationServer.Core.RsaKey
{
    public interface IKeyLoader
    {
        Task<RsaSecurityKey> LoadAsync();
    }
}
