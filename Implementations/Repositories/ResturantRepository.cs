using CommunityProApp.Context;
using CommunityProApp.Dtos;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CommunityProApp.Implementations.Repositories
{
    public class ResturantRepository : BaseRepository<FoodItem>, IResturantRepository
    {
        
        public ResturantRepository(ApplicationContext context)
        {
            _context = context;
        }
        public FoodItem GetFoodItemsByCategory(Guid categoryId)
        {
            return _context.FoodItems.Include(d => d.FoodItemsCategories.ThenInclude(pc => pc.Category).Where(vc => vc.FoodItemsCategories.Any(fc =>fc.CategoryId == categoryId)).ToList();

        public IList<FoodItemDto> Search(string searchText)
        {
            return _context.FoodItems.Where(FoodItem => EF.Functions.Like(FoodItem.Name, $"%{searchText}%")).Select(p => new FoodItemDto
            {
                Id = p.Id,
                Name = p.Name,
                Discount = p.Discount,
                Price = p.Price,
                ProductImage = p.ProductImage,
                ProductAdditionalImage1 = p.ProductAdditionalImage1,
                ProductAdditionalImage2 = p.ProductAdditionalImage2,
                Rating = p.Rating
            }).ToList();
        }
    }
}
