using System;

namespace CommunityProApp.Entities
{
    public class OrderFoodItem
    {

        public Guid OrderId { get; set; }

        public Order Order { get; set; }

        public Guid FoodItemId { get; set; }

        public FoodItem FoodItem { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }
    }
}
