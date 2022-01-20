using CommunityProApp.Dtos;
using CommunityProApp.Entities;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Interfaces.Services
{
    public interface IProductService
    {
        BaseResponse AddProduct(CreateProductRequestModel model);

        BaseResponse UpdateProduct(Guid id, UpdateProductRequestModel model);

        ProductDto ProductDetail(Guid id);

        IList<ProductDto> GetProducts();

        IList<ProductDto> GetProductsByCategory(Guid categoryId);

        IList<ProductDto> SearchProducts(string searchText);

    }
}
