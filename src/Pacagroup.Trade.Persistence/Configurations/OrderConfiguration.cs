using Microsoft.EntityFrameworkCore;
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

            builder.HasKey(x => x.Side);
        }
    }
}
