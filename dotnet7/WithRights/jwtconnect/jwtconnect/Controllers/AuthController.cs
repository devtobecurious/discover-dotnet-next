using jwtconnect.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Text;

namespace jwtconnect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private IConfiguration configuration;

        public AuthController(IConfiguration conf)
        {
            this.configuration = conf;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] AuthUser user)
        {
            IActionResult result = this.Unauthorized();

            if (user != null)
            {
                
                user.Token = this.CreateToken(user);

                result = this.Ok(user);
            }

            return this.Ok(user);
        }

        private string CreateToken(AuthUser model)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["jwt:key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(this.configuration["jwt:issuer"],
                                             this.configuration["jwt:issuer"],
                                             expires: DateTime.Now.AddMinutes(30),
                                             signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
