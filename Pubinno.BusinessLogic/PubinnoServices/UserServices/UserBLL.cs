using AutoMapper;
using Pubinno.BusinessLogic.Abstract.IUserBLL;
using Pubinno.DataAccess.Abstract;
using Pubinno.Shared.PubinnoDTOs.PubinnoIdentity;
using System.Threading.Tasks;

namespace Pubinno.BusinessLogic.PubinnoServices.UserServices
{
    public class UserBLL : IUserBLL
    {
        private readonly IUserDAL _userDAL;
        private readonly IMapper _mapper;

        public UserBLL(IUserDAL userDAL, IMapper mapper)
        {
            _userDAL = userDAL;
            _mapper = mapper;
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var user = await _userDAL.GetUserById(id);
            return _mapper.Map<UserDto>(user);

        }

        public async Task<LoginResponseDto> Login(LoginDto request)
        {
            var userLogin = await _userDAL.Login(request);
            return userLogin;
        }

        public async Task<bool> Register(RegisterDto request)
        {
            return await _userDAL.Register(request);
        }
    }
}
