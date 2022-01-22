using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService : 
        [HttpGet]
        public IActionResult AddItem()
        {
            return View();
        }
    }
}