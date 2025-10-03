using Microsoft.AspNetCore.Mvc;
using Top.MasonTech.NetCoreBaseAPI.Core.Application.Services.Product;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Object;
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
    public async Task<ActionResult> Search([FromBody] SearchProductDto request)
    {
        try
        {
            var result = await _productService.Search(request);
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            var error = ErrorDataResponse.InternalServerError(new ClientError() { ErrorCode = "PRODUCT_SEARCH_000", ErrorMessage = e.Message });
            return Ok(error);
        }
    }
}
