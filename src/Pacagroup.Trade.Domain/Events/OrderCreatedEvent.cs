﻿using Pacagroup.Trade.Domain.Commons;
using Pacagroup.Trade.Domain.Enuns;

namespace Pacagroup.Trade.Domain.Events
{
    public class OrderCreatedEvent :BaseEvent
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public OrderSide Side { get; set; }
        public DateTime TransactTime { get; set; }
        public int Quanty { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }

    }
}
