using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Interface;

/// <summary>
/// Base service interface
/// </summary>
public interface IBaseService<
    TSearchRequest,
    TSearchResponse,
    TResponseDto,
    TEntity,
    TId
>
    where TResponseDto : BaseItemResponse<TEntity, TId>, new()
    where TSearchRequest : BaseSearchRequest
    where TSearchResponse : BaseSearchResponse<TResponseDto>, new()
    where TEntity : BaseEntity<TId>, new()
{
    Task<BaseResponse<TSearchResponse>> Search(TSearchRequest searchRequest);
}