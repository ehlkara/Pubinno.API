using Pubinno.Shared.PubinnoDTOs.PubinnoIdentity;
using System.Threading.Tasks;

namespace Pubinno.BusinessLogic.Abstract.IUserBLL
{
    public interface IUserBLL
    {
        Task<bool> Register(RegisterDto request);
        Task<LoginResponseDto> Login(LoginDto request);
        Task<UserDto> GetUserById(int id);
    }
}
