using System.Linq.Expressions;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Constant;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

/// <summary>
/// Represents the base class for defining parameters required for a search request.
/// </summary>
/// <remarks>
/// The BaseSearchRequest class is used to provide definitions for pagination, filtering, and sorting
/// in search operations. It includes properties for specifying the page number, page size, filters to
/// apply, and sorting preferences such as sort direction.
/// </remarks>
public abstract class BaseSearchRequest
{
    public int PageNumber { get; set; } = ConstantValue.PageIndex;

    public int PageSize { get; set; } = ConstantValue.PageSize;

    public BaseSearchFilter[] FilterBy { get; set; } = [];

    // public string? SortColumn { get; set; }

    public bool IsDescending { get; set; } = false;

    public Expression<Func<T, bool>> GenerateQuery<T, TId>() where T : BaseEntity<TId>, new()
    {
        var parameter = Expression.Parameter(typeof(T), "x");
        Expression? body = null;
        foreach (var filter in FilterBy)
        {
            var property = Expression.Property(parameter, filter.FieldName);
            Expression condition;
            if (filter.FieldValue == null)
            {
                // x.Property == null
                condition = Expression.Equal(property, Expression.Constant(null, property.Type));
            }
            else
            {
                var constant = Expression.Constant(filter.FieldValue);
                var converted = Expression.Convert(constant, property.Type);
                condition = Expression.Equal(property, converted);
            }

            body = body == null ? condition : Expression.AndAlso(body, condition);
        }
        if (body == null)
        {
            body = Expression.Constant(true); // no filters
        }
        return Expression.Lambda<Func<T, bool>>(body, parameter);
    }
}
