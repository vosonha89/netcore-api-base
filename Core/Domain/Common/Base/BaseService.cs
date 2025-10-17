using System.Net;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Interface;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

public class BaseService<
    TSearchRequest,
    TSearchResponse,
    TResponseDto,
    TEntity,
    TId
> : IBaseService<TSearchRequest, TSearchResponse, TResponseDto, TEntity, TId>
    where TResponseDto : BaseItemResponse<TEntity, TId>, new()
    where TSearchRequest : BaseSearchRequest
    where TSearchResponse : BaseSearchResponse<TResponseDto>, new()
    where TEntity : BaseEntity<TId>, new()
{
    private readonly IAppRepository _appRepository;

    protected BaseService(IAppRepository repository)
    {
        _appRepository = repository;
    }

    /// <summary>
    /// Search data with filter and pagination
    /// </summary>
    /// <param name="searchRequest"></param>
    /// <returns></returns>
    public async Task<BaseResponse<TSearchResponse>> Search(TSearchRequest searchRequest)
    {
        var response = new BaseResponse<TSearchResponse>();
        var predicate = searchRequest.GenerateQuery<TEntity, TId>();
        var orderByString = searchRequest.GenerateOrderByString<TId>();
        var result = await _appRepository.Search<TEntity, TId>(predicate, orderByString, searchRequest.PageSize, searchRequest.PageNumber);
        response.Data = new TSearchResponse { Size = searchRequest.PageSize, Page = searchRequest.PageNumber };
        response.Data.Elements = result
            .Select((x) => MapResponse(x))
            .ToList();
        response.Successful = true;
        response.Status = (int)HttpStatusCode.Accepted;
        return response;
    }

    /// <summary>
    /// Map response from entity
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    private static TResponseDto MapResponse(TEntity source)
    {
        var dto = new TResponseDto();
        dto.Map(source);
        return dto;
    }
}
