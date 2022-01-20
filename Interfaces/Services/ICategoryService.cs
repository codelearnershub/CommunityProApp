using CommunityProApp.Dtos;
using CommunityProApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Interfaces.Services
{
    public interface ICategoryService
    {
        BaseResponse AddCategory(CreateCategoryRequestModel model);

        BaseResponse UpdateCategory(Guid id, UpdateCategoryRequestModel model);

        CategoryDto GetCategory(Guid id);

        IList<CategoryDto> GetCategories();

    }
}
