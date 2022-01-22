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
        public IList<OrderDto> GetFoodItemsOderByCustomer()
        {
            throw new NotImplementedException();
        }

        public IList<OrderDto> GetFoodItemsOderByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IList<OrderDto> GetFoodItemsOderByReference(string reference)
        {
            return _orderRepository.GetAll( a => a.OrderReference == reference).Select(b => new OrderDto{
                Id = b.Id,
                CustomerFullName = $"{b.Customer.FirstName}  {b.Customer.LastName}",
                DeliveryAddress = b.DeliveryAddress,
                DeliveryDate = b.DeliveryDate,
                OrderReference = b.OrderReference,
                Status = b.Status,
                TotalPrice = b.TotalPrice                
            }).ToList();
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
