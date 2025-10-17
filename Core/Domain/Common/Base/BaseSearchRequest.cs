using System.Linq.Expressions;
using System.Text.Json;
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

    public BaseSort[] OrderBy { get; set; } = [];

    public Expression<Func<T, bool>> GenerateQuery<T, TId>() where T : BaseEntity<TId>, new()
    {
        var parameter = Expression.Parameter(typeof(T), "x");
        Expression? body = null;
        foreach (var filter in FilterBy)
        {
            var property = Expression.Property(parameter, filter.FieldName);
            Expression condition;
            string? rawValue;
            if (filter.FieldValue is JsonElement rawJsonElement)
            {
                rawValue = rawJsonElement.GetRawText();
            }
            else
            {
                rawValue = filter.FieldValue.ToString();
            }

            var constant = Expression.Constant(rawValue);
            var converted = Expression.Convert(constant, property.Type);
            condition = Expression.Equal(property, converted);

            body = body is null ? condition : Expression.AndAlso(body, condition);
        }
        if (body is null)
        {
            body = Expression.Constant(true); // no filters
        }
        return Expression.Lambda<Func<T, bool>>(body, parameter);
    }

    /// <summary>
    /// Generate order by string
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    /// <returns></returns>
    public string GenerateOrderByString<TId>()
    {
        if (!OrderBy.Any())
        {
            return $"{nameof(BaseEntity<TId>.Id)} ASC";
        }
        var clauses = OrderBy.Select(x => $"{x.FieldName} {(x.IsDescending ? "DESC" : "ASC")}");
        return string.Join(", ", clauses);
    }
}
