using Nlayer.Core.DTOs;

namespace Nlayer.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>>  GetProductsWithCategory();

    }
}
