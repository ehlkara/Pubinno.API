using Microsoft.AspNetCore.Identity;
using Pubinno.Models.Enums;

namespace Pubinno.Models.Entities.Pubinno.IdentityAuth
{
    public class PubinnoUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public UserType UserType { get; set; }
    }
}
