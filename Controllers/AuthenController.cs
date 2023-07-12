using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {

        public static Users users = new Users();
        private readonly IConfiguration _configuration;

        public AuthenController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet, Authorize]
        public ActionResult<string>GetMyName()
        {
         var roleClaims = User?.FindAll(ClaimTypes.Role);
         var roles = roleClaims?.Select(c => c.Value).ToList();
     
            return Ok(users);
        }

        [HttpPost("Register")]
        public ActionResult<Users> Register(UsersDTO request)
        {
            string passwordHash
                = BCrypt.Net.BCrypt.HashPassword(request.Password);

            users.FirstName = request.FirstName;
            users.MiddleName = request.MiddleName;
            users.LastName = request.LastName;
            users.Gender = request.Gender;
            users.UserName = request.UserName;
            users.PasswordHash = passwordHash;

            return Ok(users);
        }

        [HttpPost("Login")]
        public ActionResult<Users> Login(UsersDTO request)
        {
            if (users.FirstName != request.FirstName)
            {
                return BadRequest("User not found.");
            }

            if (users.MiddleName != request.MiddleName)
            {
                return BadRequest("User not found.");
            }

            if (users.LastName != request.LastName)
            {
                return BadRequest("User not found.");
            }

            if (users.Gender != request.Gender)
            {
                return BadRequest("User not found.");
            }

            if (users.UserName != request.UserName)
            {
                return BadRequest("User not found.");
            }

            if (!BCrypt.Net.BCrypt.Verify(request.Password, users.PasswordHash))
            {
                return BadRequest("Wrong password.");
            }

            string token = CreateToken(users);

            var refreshToken=GenerateRefreshToken();
            SetRefreshToken(refreshToken);

         return Ok(token);
        }

        private RefreshToken GenerateRefreshToken()
        {
            var refreshToken = new RefreshToken
            {
                Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                Expires = DateTime.Now.AddDays(30)
            };

            return refreshToken;
        }

        private void SetRefreshToken(RefreshToken newRefreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = newRefreshToken.Expires,
            };
            Response.Cookies.Append("refreshToken", newRefreshToken.Token, cookieOptions);

            users.RefreshToken = newRefreshToken.Token;
            users.TokenCreated = newRefreshToken.Created;
            users.TokenExpires = newRefreshToken.Expires;
        }

    private string CreateToken(Users users)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, "Admins"),
                new Claim(ClaimTypes.Role, "Users")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                             _configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(30),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}

