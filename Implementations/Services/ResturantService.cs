using CommunityProApp.Dtos;
using CommunityProApp.Interfaces.Repositories;
using CommunityProApp.Interfaces.Services;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommunityProApp.Implementations.Services
{
    public class ResturantService : IResturantService
    {
        private readonly IResturantRepository _resturantRepository;

        public ResturantService(IResturantRepository resturantRepository)
        {
            _resturantRepository = resturantRepository;
        }
        public BaseResponse AddFoodItem(CreateFoodItemRequesModel model)
        {
            throw new NotImplementedException();
        }

        public IList<FoodItemDto> DisplayFoodItems()
        {
            throw new NotImplementedException();
        }

        public FoodItemDto FoodItemDetail(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<FoodItemDto> GetFoodItemsByCategory(Guid categoryId)
        {
            _resturantRepository.GetFoodItemsByCategory(categoryId).Select(fc => new FoodItemDto{
            Name = fc.Name,
            Description = fc.Description,
            Discount = fc.Discount,
            Price = fc.Price,
            Id = fc.Id,
            Rating = fc.Rating,
            ProductAdditionalImage1 = fc.ProductImage1,
            ProductAdditionalImage2 = fc.ProductImage2,
            ProductImage= fc.ProdctIage
            }).ToList();
        }

        public IList<FoodItemDto> SearchFoodItems(string searchText)
        {
            var foodItem = _resturantRepository.Search(searchText).ToList();
            if(foodItem == null)
            {
                throw new Exception($"The food item you are searching for is not found");
            }
            else
            {
                return foodItem;
            }
        }

        public BaseResponse UpdateFoodItem(Guid id, UpdateFoodItemRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
