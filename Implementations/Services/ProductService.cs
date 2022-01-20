using CommunityProApp.Dtos;
using CommunityProApp.Entities;
using CommunityProApp.Implementations.Repositories;
using CommunityProApp.Interfaces.Repositories;
using CommunityProApp.Interfaces.Services;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Implementations.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public BaseResponse AddProduct(CreateProductRequestModel model)
        {
            var productExist = _productRepository.Exists(d => d.Name == model.Name);
            if (productExist)
            {
                throw new Exception($"Product with name {model.Name} already exist");
            }
            else
            {
                var product = new Product
                {
                    Name = model.Name,
                    Description = model.Description,
                    Discount = model.Discount,
                    LifeSpanDuration = model.LifeSpanDuration,
                    Price = model.Price,
                    Status = Enums.ProductStatus.Available,
                    ProductionDate = model.ProductionDate,
                    ProductImage = model.ProductImage,
                    ProductAdditionalImage1 = model.ProductAdditionalImage1,
                    ProductAdditionalImage2 = model.ProductAdditionalImage2

                };
                _productRepository.Create(product);
                return new BaseResponse
                {
                    Message = $"{product.Name} Successfully created.",
                    Status = true
                };
            }
        }


        public IList<ProductDto> GetProducts()
        {
            return _productRepository.Get().Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Discount = product.Discount,
                Price = product.Price,
                ProductImage = product.ProductImage,
                Rating = product.Rating,
                Status = product.Status
            }).ToList();
        }

        public IList<ProductDto> GetProductsByCategory(Guid categoryId)
        {
            return _productRepository.GetProductsByCategory(categoryId).Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Discount = product.Discount,
                Price = product.Price,
                ProductImage = product.ProductImage,
                Rating = product.Rating,
                Status = product.Status
            }).ToList();
        }

        public ProductDto ProductDetail(Guid id)
        {
            var product = _productRepository.Get(id);
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Discount = product.Discount,
                Price = product.Price,
                ProductImage = product.ProductImage,
                ProductAdditionalImage1 = product.ProductAdditionalImage1,
                ProductAdditionalImage2 = product.ProductAdditionalImage2,
                Description = product.Description,
                LifeSpanDuration = product.LifeSpanDuration,
                //Comments = product.Comments,
                ProductionDate = product.ProductionDate,
                Rating = product.Rating,
                Status = product.Status
            };
        }

        public IList<ProductDto> SearchProducts(string searchText)
        {
            return _productRepository.Search(searchText).ToList();
        }

        public BaseResponse UpdateProduct(Guid id, UpdateProductRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
