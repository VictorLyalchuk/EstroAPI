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
    public class ImageConfiguratio : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            //Set Primary Key
            //builder.HasKey(x => x.Id);

            ////Set Property configurations

            //Set Relationship configurations
            //builder.HasOne<Product>(i => i.Product)
            //       .WithMany(p => p.Images)
            //       .HasForeignKey(i => i.ProductId);
        }
    }
}
