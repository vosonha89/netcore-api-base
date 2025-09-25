namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

/// <summary>
/// Base item response for entity data
/// </summary>
/// <typeparam name="TSource"></typeparam>
/// <typeparam name="TId"></typeparam>
public abstract class BaseItemResponse<TSource, TId>
{
    /// <summary>
    /// Entity identifier
    /// </summary>
    public required TId Id { get; set; }

    /// <summary>
    /// Creation timestamp
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Last update timestamp
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Maps properties from the source object to this response
    /// </summary>
    /// <param name="source">Source object to map from</param>
    public virtual void Map(TSource source)
    {
        // Base implementation to be overridden by derived classes
        // Object mapping will depend on implementation details
    }
}