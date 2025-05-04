using Company.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Company.API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners  { get; set; }
        public DbSet<Brand> Brands  { get; set; }
        public DbSet<Service> Services  { get; set; }
        public DbSet<SocialMedia> SocialMedias  { get; set; }
        public DbSet<SubscribeUser>  SubscribeUsers { get; set; }
    }
}
