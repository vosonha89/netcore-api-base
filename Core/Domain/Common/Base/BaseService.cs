using System.Net;
using Microsoft.EntityFrameworkCore;
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
    protected readonly IAppRepository AppRepository;

    public BaseService(IAppRepository repository)
    {
        AppRepository = repository;
    }

    public async Task<BaseResponse<TSearchResponse>> Search(TSearchRequest searchRequest)
    {
        var response = new BaseResponse<TSearchResponse>();
        var predicate = searchRequest.GenerateQuery<TEntity, TId>();
        var resultQuery = AppRepository.GetList<TEntity>(predicate)
            .Skip((searchRequest.PageNumber - 1) * searchRequest.PageSize)
            .Take(searchRequest.PageSize)
            .AsQueryable();
        var result = await resultQuery.ToListAsync();
        response.Data = new TSearchResponse
        {
            Size = searchRequest.PageSize,
            Page = searchRequest.PageNumber
        };
        response.Data.Elements = result.Select(x =>
        {
            var dto = new TResponseDto();
            dto.Map(x);
            return dto;
        }).ToList();
        response.Successful = true;
        response.Status = (int)HttpStatusCode.Accepted;
        return response;
    }
}