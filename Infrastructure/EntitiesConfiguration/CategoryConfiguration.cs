using Core.Entities.Site;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntitiesConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Set Primary Key
            builder.HasKey(c => c.Id);

            //Set Property configurations
            builder.Property(c => c.Name)
                   .HasMaxLength(180)
                   .IsRequired();

            //Set Relationship configurations
            builder.HasMany(c => c.Products)
                   .WithOne(c => c.Category)
                   .HasForeignKey(c => c.CategoryId);

            // Category to SubCategory (One-to-Many)
            builder
                .HasOne(c => c.SubCategory)
                .WithMany(s => s.Categories)
                .HasForeignKey(s => s.SubCategoryId);

            // Optionally, configure cascade delete behavior if needed
            builder
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
