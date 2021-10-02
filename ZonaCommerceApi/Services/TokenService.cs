using System;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using ZonaCommerceApi.Models;
using Microsoft.Extensions.Configuration;


namespace ZonaRepository.Services
{
    public class TokenService
    {
        public IConfiguration Configuration { get; }
        public TokenService(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        public string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Configuration["Key"]);
        }
    }
}
