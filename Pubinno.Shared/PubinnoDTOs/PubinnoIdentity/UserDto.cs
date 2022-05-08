using Pubinno.Models.Enums;
using Pubinno.Shared.PubinnoDTOs.CoreDto;

namespace Pubinno.Shared.PubinnoDTOs.PubinnoIdentity
{
    public class UserDto : BaseDto
    {
        public string FullName { get; set; }
        public string Type { get; set; }
    }
}
