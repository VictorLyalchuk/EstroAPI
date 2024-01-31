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
    public class MainCategoryConfiguration : IEntityTypeConfiguration<MainCategory>
    {
        public void Configure(EntityTypeBuilder<MainCategory> builder)
        {
            //Set Primary Key
            builder.HasKey(c => c.Id);

            //Set Property configurations
            builder.Property(c => c.Name)
                   .HasMaxLength(180)
                   .IsRequired();

            //Set Relationship configurations
            builder.HasMany(c => c.SubCategories)
                   .WithOne(c => c.MainCategory)
                   .HasForeignKey(c => c.MainCategoryId);
        }
    }
}
