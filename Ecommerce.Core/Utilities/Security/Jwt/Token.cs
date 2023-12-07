using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Ecommerce.Core.Entities.Concrete;

namespace Ecommerce.Core.Utilities.Security.Jwt;

public static class Token
{
    public static string CreateToken(BaseUser user, string[] role)
    {
        // JwtConfiguration jwtConfiguration = new();
        var jwtHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes("wejahddksshrmdlsnrjtndlsouytqazljksdfkjiweour");
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                     new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
                     new Claim(JwtRegisteredClaimNames.Email, user.Email),
                     new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                     new Claim (ClaimTypes.Role, string.Join(",",role)),
                 }),
            Expires = DateTime.UtcNow.AddMinutes(30),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            Issuer = "ComparAcademy",
            Audience = "ComparAcademy"
        };

        var token = jwtHandler.CreateToken(tokenDescriptor);
        return jwtHandler.WriteToken(token);

    }
}