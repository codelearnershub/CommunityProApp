using CommunityProApp.Context;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Repositories;

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
        }
    }
}
