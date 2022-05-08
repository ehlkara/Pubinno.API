using Pubinno.Models.Enums;
using Pubinno.Shared.PubinnoDTOs.CoreDto;

namespace Pubinno.Shared.PubinnoDTOs.PubinnoIdentity
{
    public class LoginResponseDto : BaseDto
    {

        public string FullName { get; set; }
        public string AccessToken { get; set; }
        public string UserType { get; set; }
    }
}
