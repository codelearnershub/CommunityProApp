using CommunityProApp.Dtos;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;

namespace CommunityProApp.Interfaces.Services
{
    public interface IOrderService
    {
        IList<OrderDto> GetFoodItemsOderByDate(DateTime date);

        IList<OrderDto> GetFoodItemsOderByCustomer(Guid customerId);

        BaseResponse OrderFoodItems(CreateOrderRequestModel model);

        BaseResponse OrderProducts (CreateOrderRequestModel model);
    }
}
