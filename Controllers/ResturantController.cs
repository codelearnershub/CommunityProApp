using CommunityProApp.Dtos;
using CommunityProApp.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace CommunityProApp.Controllers
{
    public class ResturantController : Controller
    {
        private readonly IResturantService _restaurantService;
        private readonly IOrderService _orderService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ResturantController(IResturantService restaurantService, IOrderService orderService, IWebHostEnvironment webHostEnvironment)
        {
            _restaurantService = restaurantService;
            _orderService = orderService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
           
            return View( _restaurantService.DisplayFoodItems());
        }

        [HttpGet]
        public IActionResult AddFoodItem()
        {
            return View();
        }

        [HttpPost]
          public IActionResult AddFoodItem(CreateFoodItemRequesModel model , IFormFile productImage,IFormFile productAdditionalImage1,IFormFile productAdditionalImage2)
        {
            if(productImage != null)
            {
                string productImagePath = Path.Combine(_webHostEnvironment.WebRootPath , "ProductImage");
                Directory.CreateDirectory(productImagePath);
                string contentType = productImage.ContentType.Split('/')[1];
                string photoImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(productImagePath , photoImage);
                using(var fileStream = new FileStream(fullPath , FileMode.Create))
                {
                    productImage.CopyTo(fileStream);

                }
                model.ProductImage = photoImage;
            
            }
               if(productAdditionalImage1 != null)
            {
                string productAdditionalImage1PhotoPath = Path.Combine(_webHostEnvironment.WebRootPath , "productAdditionalImage1");
                Directory.CreateDirectory(productAdditionalImage1PhotoPath);
                string contentType = productAdditionalImage1.ContentType.Split('/')[1];
                string photoImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(productAdditionalImage1PhotoPath , photoImage);
                using(var fileStream = new FileStream(fullPath , FileMode.Create))
                {
                    productAdditionalImage1.CopyTo(fileStream);

                }
                model.ProductAdditionalImage1 = photoImage;
            
            }
               if(productAdditionalImage2 != null)
            {
                string productAdditionalImage2PhotoPath = Path.Combine(_webHostEnvironment.WebRootPath , "productAdditionalImage2");
                Directory.CreateDirectory(productAdditionalImage2PhotoPath);
                string contentType = productAdditionalImage2.ContentType.Split('/')[1];
                string photoImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(productAdditionalImage2PhotoPath , photoImage);
                using(var fileStream = new FileStream(fullPath , FileMode.Create))
                {
                    productAdditionalImage2.CopyTo(fileStream);

                }
                model.ProductAdditionalImage2 = photoImage;
            
            }
           var foodItem = _restaurantService.AddFoodItem(model);
            return View(foodItem);
        }
        
        public IActionResult FoodItemDetails(int id)
        {
           var foodItem = _restaurantService.FoodItemDetail(id);
            if (foodItem == null)
            {
                return NotFound();
            }
            return View(foodItem);
        }
        public IActionResult UpdateFoodItem(int id)
        {
            var foodItem = _restaurantService.FoodItemDetail(id);
            if (foodItem == null)
            {
                return NotFound();
            }
           return View();
        }
        [HttpPost]
         public IActionResult UpdateFoodItem(int id , UpdateFoodItemRequestModel model ,IFormFile productImage,IFormFile productAdditionalImage1,IFormFile productAdditionalImage2 )
        {
           if(productImage != null)
            {
                string productImagePath = Path.Combine(_webHostEnvironment.WebRootPath , "UpdateProductImage");
                Directory.CreateDirectory(productImagePath);
                string contentType = productImage.ContentType.Split('/')[1];
                string photoImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(productImagePath , photoImage);
                using(var fileStream = new FileStream(fullPath , FileMode.Create))
                {
                    productImage.CopyTo(fileStream);

                }
                model.ProductImage = photoImage;
            
            }
               if(productAdditionalImage1 != null)
            {
                string productAdditionalImage1PhotoPath = Path.Combine(_webHostEnvironment.WebRootPath , "UpdateproductAdditionalImage1");
                Directory.CreateDirectory(productAdditionalImage1PhotoPath);
                string contentType = productAdditionalImage1.ContentType.Split('/')[1];
                string photoImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(productAdditionalImage1PhotoPath , photoImage);
                using(var fileStream = new FileStream(fullPath , FileMode.Create))
                {
                    productAdditionalImage1.CopyTo(fileStream);

                }
                model.ProductAdditionalImage1 = photoImage;
            
            }
               if(productAdditionalImage2 != null)
            {
                string productAdditionalImage2PhotoPath = Path.Combine(_webHostEnvironment.WebRootPath , "UpdateproductAdditionalImage2");
                Directory.CreateDirectory(productAdditionalImage2PhotoPath);
                string contentType = productAdditionalImage2.ContentType.Split('/')[1];
                string photoImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(productAdditionalImage2PhotoPath , photoImage);
                using(var fileStream = new FileStream(fullPath , FileMode.Create))
                {
                    productAdditionalImage2.CopyTo(fileStream);

                }
                model.ProductAdditionalImage2 = photoImage;
            
            }
           var response = _restaurantService.UpdateFoodItem(id,model);
            return View(response);
        }
        public IActionResult GetFoodItemByCategory(int categoryId)
        {
            var foodItem = _restaurantService.GetFoodItemsByCategory(categoryId);
            if (foodItem == null)
            {
                return NotFound();
            }
            return View(foodItem);
        }
         public IActionResult SearchFoodItems()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchFoodItems(string searchText)
        {
           var foodItems = _restaurantService.SearchFoodItems(searchText);
           if (foodItems == null)
           {
               return NotFound();
           }
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
