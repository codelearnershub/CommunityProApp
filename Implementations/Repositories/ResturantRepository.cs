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
    }
}
