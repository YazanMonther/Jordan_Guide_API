using Entites.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using ServiceContract;
using ServiceContract.DTO;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Services
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration _configuration;

        public JwtService(IConfiguration configuration)
        {
            this._configuration = configuration;
        }


        /// <summary>
        /// Creating JWT TOKEN
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public AuthentacationResponse CreateJwtToken(ApplicationUser login)
        {
            //getiing the Expiration 
            DateTime expiration = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:Expiration_Minutes"]));

            //Generate the token data
            Claim[] claims = new Claim[]
            {
               new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub,login.Id.ToString()),

               new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()), //token ID

               new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),//Issued time and date

               new Claim(ClaimTypes.NameIdentifier,login.Email.ToString()),

               new Claim(ClaimTypes.Name,login?.PersonName)
            };

            //getting the key 
            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF32.GetBytes(_configuration["Jwt:Key"]));

            //choose the Algo
            SigningCredentials signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken tokenGen = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: expiration,
                signingCredentials: signingCredentials
                );

            //  Handle Jwt response Format
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            string token = tokenHandler.WriteToken(tokenGen);

            return new AuthentacationResponse() { Token = token, Email = login.Email, Expiration = expiration, PersonName = login.Email };

        }

    }
}
//"Jwt": {
//    "Issuer": "TourismApi",
//  "Audience": "TheFlutterApp",
//  "Expiration_Minutes": 10
//}