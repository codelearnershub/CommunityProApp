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

        public IEnumerable<Cart> OrderItems { get; set; }

        public DateTime DeliveryDate { get; set; }

    }
    public class Cart
    {
        public Guid ItemId { get; set; }

        public int Quantity { get; set; }
    }
}
