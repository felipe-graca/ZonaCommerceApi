using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using ZonaCommerceApi.Models;

namespace ZonaCommerceApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<User> Users {get; set;}

    }
}
