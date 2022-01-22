using CommunityProApp.Enums;
using System;
using System.Collections.Generic;

namespace CommunityProApp.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public string OrderReference { get; set; }

        public Guid CustomerId { get; set; }

        public string CustomerFullName { get; set; }

        public OrderStatus Status { get; set; }

        public string DeliveryAddress { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime DeliveryDate { get; set; }
    }

    public class CreateOrderRequestModel
    {
        public Guid CustomerId { get; set; }

        public string DeliveryAddress { get; set; }

        public List<Guid> ProductIds { get; set; }

        public DateTime DeliveryDate { get; set; }

    }
}
