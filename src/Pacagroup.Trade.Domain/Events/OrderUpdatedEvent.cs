﻿using Pacagroup.Trade.Domain.Commons;
using Pacagroup.Trade.Domain.Enuns;

namespace Pacagroup.Trade.Domain.Events
{
    public class OrderUpdatedEvent : BaseEvent
    {
        public string Id { get; set; }
        public int Quanty { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
        public string? Text { get; set; }
    }
}
