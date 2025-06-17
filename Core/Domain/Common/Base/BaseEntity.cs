namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Base;

/// <summary>
/// Abstract base entity class that provides common fields for all entities
/// </summary>
/// <typeparam name="TId">The type of the identifier field</typeparam>
public interface IBaseEntity<TId>
{
    /// <summary>
    /// Unique identifier for the entity
    /// </summary>
    TId Id { get; set; }

    /// <summary>
    /// Timestamp when the entity was created
    /// </summary>
    DateTime CreatedAt { get; set; }

    /// <summary>
    /// Timestamp when the entity was last updated
    /// </summary>
    DateTime UpdatedAt { get; set; }

    /// <summary>
    /// Timestamp when the entity was softly deleted, null if not deleted
    /// </summary>
    DateTime? DeletedAt { get; set; }
}