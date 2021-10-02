using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ZonaCommerceApi.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}