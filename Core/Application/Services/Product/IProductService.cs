using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Interface;
using Top.MasonTech.NetCoreBaseAPI.Presentation.APIs.Product.Dtos;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Application.Services.Product;

public interface IProductService : IBaseService<
    SearchProductDto,
    BaseSearchResponse<ProductResponseDto>,
    ProductResponseDto,
    Infrastructure.Persistence.Entities.Product,
    long>
{
}