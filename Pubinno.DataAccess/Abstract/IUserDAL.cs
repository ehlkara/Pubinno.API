using Pubinno.Shared.PubinnoDTOs.PubinnoIdentity;
using System.Threading.Tasks;

namespace Pubinno.DataAccess.Abstract
{
    public interface IUserDAL
    {
        Task<bool> Register(RegisterDto request);
        Task<LoginResponseDto> Login(LoginDto request);
        Task<UserDto> GetUserById(int id);
    }
}
