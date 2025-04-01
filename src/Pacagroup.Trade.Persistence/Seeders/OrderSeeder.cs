using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pacagroup.Trade.Domain.Entities;

namespace Pacagroup.Trade.Persistence.Seeders
{
    public class OrderSeeder : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new Order
            {
                Id = 1,
                Symbol = "META",
                Side = Domain.Enuns.OrderSide.BUY,
                TransacTime = DateTime.Now,
                Quanty = 1000,
                Type = Domain.Enuns.OrderType.LIMIT,
                Price = 522.99M,

            }, new Order
            {
                Id = 2,
                Symbol = "MSFT",
                Side = Domain.Enuns.OrderSide.BUY,
                TransacTime = DateTime.Now,
                Quanty = 300,
                Type = Domain.Enuns.OrderType.LIMIT,
                Price = 424.30M
            },
            new Order
            {
                Id = 3,
                Symbol = "AMZN",
                Side = Domain.Enuns.OrderSide.SELL,
                TransacTime = DateTime.Now,
                Quanty = 400,
                Type = Domain.Enuns.OrderType.MARKET,
                Price = 0
            },
            new Order
            {
                Id = 4,
                Symbol = "TSLA",
                Side = Domain.Enuns.OrderSide.SELL,
                TransacTime = DateTime.Now,
                Quanty = 800,
                Type = Domain.Enuns.OrderType.MARKET,
                Price = 0
            }
            );

        }
    }
}
