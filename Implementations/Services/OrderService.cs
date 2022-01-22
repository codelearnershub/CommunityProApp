using CommunityProApp.Dtos;
using CommunityProApp.Interfaces.Repositories;
using CommunityProApp.Interfaces.Services;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommunityProApp.Implementations.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IList<OrderDto> GetFoodItemsOderByCustomer(Guid customerId)
        {
            return _orderRepository.GetAll(c => c.CustomerId == customerId).Select(a => new OrderDto
            {
                Id = a.Id,
                CustomerId = a.CustomerId,
                Status = a.Status,
                OrderReference  = a.OrderReference,
                DeliveryAddress = a.DeliveryAddress,
                DeliveryDate = a.DeliveryDate,
                TotalPrice = a.TotalPrice
            }).ToList();
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
