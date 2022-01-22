using CommunityProApp.Dtos;
using CommunityProApp.Interfaces.Repositories;
using CommunityProApp.Interfaces.Services;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;

namespace CommunityProApp.Implementations.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
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
