using CommunityProApp.Dtos;
using CommunityProApp.Entities;
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
          
           return _resturantRepository.Get().Select(foodItem => new FoodItemDto 
           {
                Id=foodItem.Id,
                  Name=foodItem.Name,
                  Description=foodItem.Description,
                  Price=foodItem.Price,
                  Discount=foodItem.Discount,
                  ProductImage=foodItem.ProductImage,
                  Rating=foodItem.Rating,
                  ProductAdditionalImage1=foodItem.ProductAdditionalImage1,
                  ProductAdditionalImage2=foodItem.ProductAdditionalImage2, 
           }).ToList();
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
