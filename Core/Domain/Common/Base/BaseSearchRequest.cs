using System.Linq.Expressions;
using DevNetCore.SimpleRepository.Abstract;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Constant;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base
{
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

    /// <summary>
    /// Represents a filter to be applied during a search operation.
    /// </summary>
    /// <remarks>
    /// The BaseSearchFilter class is used to define filtering criteria on data during a search process.
    /// It contains the name of the field to filter by and the value to filter against.
    /// </remarks>
    public class BaseSearchFilter
    {
        public string FieldName { get; set; }
        public dynamic FieldValue { get; set; }

        public BaseSearchFilter(string fieldName, dynamic fieldValue)
        {
            FieldName = fieldName;
            FieldValue = fieldValue;
        }
    }
}