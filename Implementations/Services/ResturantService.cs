using CommunityProApp.Dtos;
using CommunityProApp.Interfaces.Services;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;

namespace CommunityProApp.Implementations.Services
{
    public class ResturantService : IResturantService
    {
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
            throw new NotImplementedException();
        }

        public IList<FoodItemDto> SearchFoodItems(string searchText)
        {
            throw new NotImplementedException();
        }

        public BaseResponse UpdateFoodItem(Guid id, UpdateFoodItemRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
