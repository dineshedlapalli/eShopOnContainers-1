﻿namespace eShopOnContainers.Services.IntegrationEvents.Events
{
    public class OrderPaymentFailedIntegrationEvent
    {
        public int OrderId { get; }

        public OrderPaymentFailedIntegrationEvent(int orderId) => OrderId = orderId;
    }
}