using Nlayer.Core;
using Nlayer.Core.DTOs;
using Nlayer.Core.Services;

namespace Nlayer.Service.Services
{
    public interface ICategoryService : IService<Category>
    {

        Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);

    }
}
