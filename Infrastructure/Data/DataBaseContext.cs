using Core.Entities.DashBoard;
using Core.Entities.Information;
using Core.Entities.Site;
using Infrastructure.EntitiesConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Infrastructure.Data
{
    public class DataBaseContext : IdentityDbContext
    {
        public DataBaseContext() : base() { }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new MainCategoryConfiguration());
            builder.ApplyConfiguration(new SubCategoryConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new OptionsConfiguration());
            builder.ApplyConfiguration(new BagConfiguration());

            builder.Entity<MainCategory>().HasData(SeedData.SeedMainCategory());
            builder.Entity<SubCategory>().HasData(SeedData.SeedSubCategory());
            builder.Entity<Category>().HasData(SeedData.SeedCategory());
            builder.Entity<Product>().HasData(SeedData.SeedProduct());
            builder.Entity<Image>().HasData(SeedData.SeedImage());
            builder.Entity<Storage>().HasData(SeedData.SeedStorage());
            builder.Entity<ImageForHome>().HasData(SeedData.SeedImageForHome());

            builder.Entity<Info>().HasData(SeedData.SeedInfos());
            builder.Entity<Options>().HasData(SeedData.SeedOptions());

        }
        public DbSet<User> User { get; set; }

        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<ImageForHome> ImageForHome { get; set; }


        public DbSet<Info> Info { get; set; }
        public DbSet<Options> Options { get; set; }
    }
}
