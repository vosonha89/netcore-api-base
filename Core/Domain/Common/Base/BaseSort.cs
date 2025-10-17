namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

/// <summary>
/// Base sort
/// </summary>
public class BaseSort
{
    public string FieldName { get; set; }
    public bool IsDescending { get; set; }

    public BaseSort(string fieldName, bool isDescending)
    {
        FieldName = fieldName;
        IsDescending = isDescending;
    }
}
