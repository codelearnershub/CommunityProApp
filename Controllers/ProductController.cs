using CommunityProApp.Dtos;
using CommunityProApp.Interfaces.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProductService productService, ICategoryService categoryService, IWebHostEnvironment webHostEnvironment)
        {
            _productService = productService;
            _categoryService = categoryService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var products = _productService.GetProducts().Take(10);
            return View(products);
        }

        public IActionResult AdminProductsIndex()
        {
            var products = _productService.GetProducts();
            return View(products);
        }

        public IActionResult Create()
        {
            var categories = _categoryService.GetCategories();
            ViewData["Categories"] = new SelectList(categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductRequestModel model, IFormFile image, IFormFile image1, IFormFile image2)
        {
            if (image != null)
            {
                string imageDirectory = Path.Combine(_webHostEnvironment.WebRootPath, "productImages");
                Directory.CreateDirectory(imageDirectory);
                string contentType = image.ContentType.Split('/')[1];
                string contentType1 = image1.ContentType.Split('/')[1];
                string contentType2 = image2.ContentType.Split('/')[1];
                string productImage = $"{Guid.NewGuid()}.{contentType}";
                string productImage1 = $"{Guid.NewGuid()}.{contentType1}";
                string productImage2 = $"{Guid.NewGuid()}.{contentType2}";
                string fullPath = Path.Combine(imageDirectory, productImage);
                string fullPath1 = Path.Combine(imageDirectory, productImage1);
                string fullPath2 = Path.Combine(imageDirectory, productImage2);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
                using (var fileStream = new FileStream(fullPath1, FileMode.Create))
                {
                    image1.CopyTo(fileStream);
                }
                using (var fileStream = new FileStream(fullPath2, FileMode.Create))
                {
                    image2.CopyTo(fileStream);
                }
                model.ProductImage = productImage;
                model.ProductAdditionalImage1 = productImage1;
                model.ProductAdditionalImage2 = productImage2;
            }
            _productService.AddProduct(model);
            return View();
        }

        public IActionResult ProductDetails(int id)
        {
            var product = _productService.ProductDetail(id);
            return View(product);
        }

        public IActionResult SearcProduct(string search)
        {
            var products = _productService.SearchProducts(search);
            return View("Index", products);
        }
    }
}
