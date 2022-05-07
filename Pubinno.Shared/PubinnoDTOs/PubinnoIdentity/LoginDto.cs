using System.ComponentModel.DataAnnotations;

namespace Pubinno.Shared.PubinnoDTOs.PubinnoIdentity
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
