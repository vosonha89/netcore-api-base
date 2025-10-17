using Microsoft.AspNetCore.Mvc;
using Top.MasonTech.NetCoreBaseAPI.Core.Application.Services.Product;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Constant;
using Top.MasonTech.NetCoreBaseAPI.Presentation.APIs.Product.Dtos;

namespace Top.MasonTech.NetCoreBaseAPI.Presentation.APIs.Product;

[ApiController]
[Route($"{ConstantValue.ApiPrefix}/{ProductRoute.Name}")]
public class ProductController : BaseApiController<
    SearchProductDto,
    BaseSearchResponse<ProductResponseDto>,
    ProductResponseDto,
    Infrastructure.Persistence.Entities.Product,
    long
>
{
    public ProductController(IProductService productService) : base(productService)
    {
    }
}
