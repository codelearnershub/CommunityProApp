using System;

namespace CommunityProApp.Dtos
{
    public class FoodItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public double? Rating { get; set; }

        public double Discount { get; set; }

        public string ProductImage { get; set; }

        public string ProductAdditionalImage1 { get; set; }

        public string ProductAdditionalImage2 { get; set; }

    }

    public class CreateFoodItemRequesModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public double Discount { get; set; }

        public string ProductImage { get; set; }

        public string ProductAdditionalImage1 { get; set; }

        public string ProductAdditionalImage2 { get; set; }
    }

    public class UpdateFoodItemRequestModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public double Discount { get; set; }

        public string ProductImage { get; set; }

        public string ProductAdditionalImage1 { get; set; }

        public string ProductAdditionalImage2 { get; set; }
    }
}
