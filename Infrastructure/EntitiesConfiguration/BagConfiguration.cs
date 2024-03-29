﻿using Core.Entities.DashBoard;
using Core.Entities.Information;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntitiesConfiguration
{
    public class BagConfiguration : IEntityTypeConfiguration<Bag>
    {
        public void Configure(EntityTypeBuilder<Bag> builder)
        {
            //Set Primary Key
            builder.HasKey(x => x.Id);

            //Set Property configurations

            builder.HasOne(b => b.User)
                    .WithOne(u => u.Bag)
                    .HasForeignKey<Bag>(b => b.UserId);

            //Set Relationship configurations
            //builder.HasOne<User>(x => x.Users)
            //       .WithMany(x => x.Orders)
            //       .HasForeignKey(x => x.UserId);
        }
    }
}
