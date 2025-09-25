namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

/// <summary>
/// Base search response with pagination information
/// </summary>
/// <typeparam name="T">Type of elements in the search results</typeparam>
public class BaseSearchResponse<T>
{
    /// <summary>
    /// Current page number (1-based)
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// Page size
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// Total number of elements across all pages
    /// </summary>
    public int TotalElements { get; set; }

    /// <summary>
    /// Total number of pages
    /// </summary>
    public int TotalPages { get; set; }

    /// <summary>
    /// Elements on the current page
    /// </summary>
    public IList<T> Elements { get; set; } = new List<T>();

    /// <summary>
    /// Whether there are previous pages available
    /// </summary>
    public bool HasPrevious { get; set; }

    /// <summary>
    /// Whether there are more pages available
    /// </summary>
    public bool HasMore { get; set; }
}