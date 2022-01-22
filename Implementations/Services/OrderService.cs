using CommunityProApp.Dtos;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Services;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;

namespace CommunityProApp.Implementations.Services
{
    public class OrderService : IOrderService
    {
        public IList<OrderDto> GetFoodItemsOderByCustomer()
        {
            throw new NotImplementedException();
        }

        public IList<OrderDto> GetFoodItemsOderByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public BaseResponse OrderFoodItems(CreateOrderRequestModel model)
        {
            throw new NotImplementedException();
        }

        public BaseResponse OrderProducts(CreateOrderRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
