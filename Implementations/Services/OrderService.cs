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
            return _orderRepository.GetAll(a => a.Created == date).Select(a => new OrderDto { 
                Id = a.Id,
                OrderReference = a.OrderReference,
                CustomerFullName = $"{a.Customer.LastName} {a.Customer.FirstName}",
                CustomerId = a.CustomerId,
                DeliveryAddress = a.DeliveryAddress,
                DeliveryDate = a.DeliveryDate,
                Status = a.Status,
                TotalPrice = a.TotalPrice,
            }).ToList();

        }

        public IList<OrderDto> GetFoodItemsOderByReference(string reference)
        {
            return _orderRepository.Search(reference);
           
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
