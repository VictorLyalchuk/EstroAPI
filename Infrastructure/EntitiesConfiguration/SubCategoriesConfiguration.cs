using Core.Entities.Site;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntitiesConfiguration
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            //Set Primary Key
            builder.HasKey(c => c.Id);

            //Set Property configurations
            builder.Property(c => c.Name)
                   .HasMaxLength(180)
                   .IsRequired();

            //Set Relationship configurations
            builder.HasMany(c => c.Categories)
                   .WithOne(c => c.SubCategory)
                   .HasForeignKey(c => c.SubCategoryId);


            builder.HasOne(s => s.MainCategory)
                    .WithMany(m => m.SubCategories)
                    .HasForeignKey(s => s.MainCategoryId);
        }
    }
};
