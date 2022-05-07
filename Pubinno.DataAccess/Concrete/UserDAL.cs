using Abp.UI;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Pubinno.DataAccess.Abstract;
using Pubinno.Models.Entities.Pubinno.IdentityAuth;
using Pubinno.Models.Errors;
using Pubinno.Shared.PubinnoDTOs.PubinnoIdentity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Pubinno.DataAccess.Concrete
{
    public class UserDAL : IUserDAL
    {
        private readonly UserManager<PubinnoUser> _pubinnoUser;
        private readonly IConfiguration _configuration;

        public UserDAL(UserManager<PubinnoUser> pubinnoUser, IConfiguration configuration)
        {
            _pubinnoUser = pubinnoUser;
            _configuration = configuration;
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var user = await _pubinnoUser.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user != null)
            {
                var userDto = new UserDto
                {
                    Id = user.Id,
                    FullName = user.Name + " " + user.Surname,
                    Type = user.UserType
                };

                return userDto;
            }
            else
            {
                throw new UserFriendlyException((int)ErrorCodes.UserNotFound, ErrorMessages.UserNotFound);
            }
        }

        public async Task<LoginResponseDto> Login(LoginDto request)
        {
            var user = await _pubinnoUser.FindByNameAsync(request.Username);
            if (user == null)
                throw new UserFriendlyException((int)ErrorCodes.UserNotFound, ErrorMessages.UserNotFound);
            if (user != null && await _pubinnoUser.CheckPasswordAsync(user, request.Password))
            {
                var userRoles = await _pubinnoUser.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );
                return (new LoginResponseDto()
                {
                    AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                    FullName = user.Name + " " + user.Surname,
                    Id = user.Id,
                    UserType = user.UserType,
                });
            }
            else
            {
                throw new UserFriendlyException((int)ErrorCodes.PasswordWrong, ErrorMessages.PasswordWrong);
            }
        }

        public async Task<bool> Register(RegisterDto request)
        {
            var userExists = await _pubinnoUser.FindByNameAsync(request.Username);
            if (userExists != null)
                throw new UserFriendlyException((int)ErrorCodes.UserAlreadyExist, ErrorMessages.UserAlreadyExist);
            PubinnoUser user = new PubinnoUser()
            {
                Email = request.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = request.Username,
                Name = request.Name,
                Surname = request.Surname,
                UserType = request.Type
            };
            var result = await _pubinnoUser.CreateAsync(user, request.Password);
            if (!result.Succeeded)
                throw new UserFriendlyException((int)ErrorCodes.UserCannotCreate, ErrorMessages.UserCannotCreate);
            return true;
        }
    }
}
