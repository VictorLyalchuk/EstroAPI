using Core.Entities.DashBoard;
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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //Set Primary Key
            builder.HasKey(x => x.Id);

            //Set Property configurations

            //Set Relationship configurations
            builder.HasOne<User>(x => x.Users)
                   .WithMany(x => x.Orders)
                   .HasForeignKey(x => x.UserId);
        }
    }
}
