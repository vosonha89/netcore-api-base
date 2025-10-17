using Microsoft.AspNetCore.Mvc;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Interface;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Object;
using Top.MasonTech.NetCoreBaseAPI.Presentation.APIs.Product;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

public abstract class BaseApiController<
    TSearchRequest,
    TSearchResponse,
    TResponseDto,
    TEntity,
    TId
> : ControllerBase
    where TResponseDto : BaseItemResponse<TEntity, TId>, new()
    where TSearchRequest : BaseSearchRequest
    where TSearchResponse : BaseSearchResponse<TResponseDto>, new()
    where TEntity : BaseEntity<TId>, new()
{
    private readonly IBaseService<TSearchRequest, TSearchResponse, TResponseDto, TEntity, TId> _logicService;

    protected BaseApiController(IBaseService<TSearchRequest, TSearchResponse, TResponseDto, TEntity, TId> logicService)
    {
        _logicService = logicService;
    }

    [HttpPost(BaseRoute.BaseRouteV1.Search)]
    public async Task<ActionResult> Search([FromBody] TSearchRequest request)
    {
        try
        {
            var result = await _logicService.Search(request);
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            var error = ErrorDataResponse.InternalServerError(
                new ClientError()
                {
                    ErrorCode = BaseErrorCode.SearchUnknowError,
                    ErrorMessage = e.Message
                });
            return Ok(error);
        }
    }
}
