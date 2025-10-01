using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Interface;
using Top.MasonTech.NetCoreBaseAPI.Presentation.APIs.Product.Dtos;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Application.Services.Product;

/// <summary>
/// ProductService
/// </summary>
public class ProductService : BaseService<
    SearchProductDto,
    BaseSearchResponse<ProductResponseDto>,
    ProductResponseDto,
    Infrastructure.Persistence.Entities.Product,
    long
>, IProductService
{
    public ProductService(IAppRepository repository) : base(repository)
    {
    }
}