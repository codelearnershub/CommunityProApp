using CommunityProApp.Dtos;
using CommunityProApp.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Controllers
{
    public class ResturantController : Controller
    {
        private readonly IOrderService _orderService;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
         public IActionResult CreateOrder(CreateOrderRequestModel model)
        {
            var order = _orderService.OrderFoodItems(model);
            return View(order);
        }
    }
}
