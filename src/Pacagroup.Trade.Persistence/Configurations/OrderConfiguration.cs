﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pacagroup.Trade.Domain.Entities;
namespace Pacagroup.Trade.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.ToTable("Orders");
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id)
                .HasPrecision(9, 0)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(t => t.Symbol)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.Side)
                .IsRequired()
                .HasMaxLength(1);

            builder.Property(t => t.TransacTime)
                .IsRequired();

            builder.Property(t => t.Quanty)
                .HasPrecision(9, 0)
                .IsRequired();

            builder.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(1);

            builder.Property(t => t.Price)
                .HasPrecision(9, 4)
                .IsRequired();

            builder.Property(t => t.Currency)
                .HasMaxLength(3)
                .IsRequired()
                .HasDefaultValue("USD");

            builder.Property(t => t.Text)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(t => t.Create)
                .IsRequired();

            builder.Property(t => t.CreatedBy)
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(t => t.LastModified)
               .IsRequired(false);

            builder.Property(t => t.LastModifiedBy)
                .HasMaxLength(120)
                .IsRequired(false);
        }
    }
}
