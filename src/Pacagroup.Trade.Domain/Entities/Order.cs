using Pacagroup.Trade.Domain.Commons;
using Pacagroup.Trade.Domain.Enuns;

namespace Pacagroup.Trade.Domain.Entities
{
    public class Order:BaseAuditableEntity
    {
        public string Symbol { get; set; }
        public OrderSide Side { get; set; }
        public DateTime TransacTime { get; set; }
        public int Quanty { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
    }
}
