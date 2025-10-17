using System.Linq.Expressions;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Constant;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Interface;

/// <summary>
/// Application repository interface
/// </summary>
public interface IAppRepository
{
    Task<List<T>> Search<T, TId>(
        Expression<Func<T, bool>> predicate,
        string orderByString,
        int pageSize = ConstantValue.PageSize,
        int pageIndex = ConstantValue.PageIndex) where T : BaseEntity<TId>, new();
}
