using Microsoft.AspNetCore.Identity;

namespace Bits_Bytes.API.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}
