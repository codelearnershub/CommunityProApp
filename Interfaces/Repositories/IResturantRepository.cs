using CommunityProApp.Entities;

namespace CommunityProApp.Interfaces.Repositories
{
    public interface IResturantRepository : IRepository<FoodItem>
    {
        FoodItem GetFoodItemsByCategory(Guid categoryId);
    }
}
