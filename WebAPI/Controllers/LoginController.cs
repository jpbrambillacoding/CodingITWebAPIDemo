using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(LoginDTO loginDTO)
        {
            switch (loginDTO.Username)
            {
                case "admin":
                case "user1":
                case "user2":
                    if (loginDTO.Password == "password")
                    {
                        var token = GenerateJwtToken(loginDTO.Username);
                        return Ok(token);
                    }
                    break;
                default:
                    return Unauthorized();

            }

            return Unauthorized();
        }

        private string GenerateJwtToken(string username)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("CodingITLiveSessionCodingITLiveSession"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claimData = new Dictionary<string, string>
            {
                { ClaimTypes.Name, username },
                { ClaimTypes.NameIdentifier, Guid.NewGuid().ToString() },
            };

            var claims = claimData.Select(c => new Claim(c.Key, c.Value)).ToArray();


            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}