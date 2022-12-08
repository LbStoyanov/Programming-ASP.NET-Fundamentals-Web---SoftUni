using ASP.NETIntro.Core.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETIntro.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<ASP.NETIntro.Core.Models.ProductDto> ProductDto { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //}

        public DbSet<Product> Products { get; set; }
    }
}