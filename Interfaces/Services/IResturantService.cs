using CommunityProApp.Dtos;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;

namespace CommunityProApp.Interfaces.Services
{
    public interface IResturantService
    {
        BaseResponse AddFoodItem(CreateFoodItemRequesModel model);

        BaseResponse UpdateFoodItem(Guid id, UpdateFoodItemRequestModel model);

        FoodItemDto FoodItemDetail(Guid id);

        IList<FoodItemDto> DisplayFoodItems();

        IList<FoodItemDto> GetFoodItemsByCategory(Guid categoryId);

        IList<FoodItemDto> SearchFoodItems(string searchText);
    }
}
