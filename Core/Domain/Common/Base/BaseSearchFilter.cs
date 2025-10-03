namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

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
