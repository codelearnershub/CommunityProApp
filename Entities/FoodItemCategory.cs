using System;

namespace CommunityProApp.Entities
{
    public class FoodItemCategory : BaseEntity
    {
        public Guid ProductId { get; set; }

        public FoodItem FoodItem { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
