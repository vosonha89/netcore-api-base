using Microsoft.AspNetCore.Mvc;
using Top.MasonTech.NetCoreBaseAPI.Core.Application.Services.Product;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;
using Top.MasonTech.NetCoreBaseAPI.Presentation.APIs.Product.Dtos;

namespace Top.MasonTech.NetCoreBaseAPI.Presentation.APIs.Product;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost("search")]
    public async Task<BaseResponse<BaseSearchResponse<ProductResponseDto>>> Search([FromBody] SearchProductDto request)
    {
        return await _productService.Search(request);
    }
}