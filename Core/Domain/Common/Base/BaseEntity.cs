using System.ComponentModel.DataAnnotations.Schema;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

/// <summary>
/// Abstract base entity class that provides common fields for all entities
/// </summary>
/// <typeparam name="TId">The type of the identifier field</typeparam>
public abstract class BaseEntity<TId>
{
    /// <summary>
    /// Unique identifier for the entity
    /// </summary>
    [Column("id")]
    public TId? Id { get; set; }

    /// <summary>
    /// Timestamp when the entity was created
    /// </summary>
    [Column("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Timestamp when the entity was last updated
    /// </summary>
    [Column("updatedAt")]
    public DateTime? UpdatedAt { get; set; }


    /// <summary>
    /// Timestamp when the entity was softly deleted, null if not deleted
    /// </summary>
    [Column("deletedAt")]
    public DateTime? DeletedAt { get; set; }
}
