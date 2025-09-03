using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

namespace Top.MasonTech.NetCoreBaseAPI.Infrastructure.Persistence.Entities;

/// <summary>
/// Product entity
/// </summary>
[Table("product")]
public class Product : BaseEntity<long>
{
    [Column("title")][MaxLength(4000)] public string? Title { get; set; }
    [Column("description")][MaxLength(4000)] public string? Description { get; set; }
    [Column("category")][MaxLength(4000)] public string? Category { get; set; }
    [Column("price")] public double? Price { get; set; }
    [Column("discountPercentage")] public double? DiscountPercentage { get; set; }
    [Column("rating")] public double? Rating { get; set; }
    [Column("stock")] public long? Stock { get; set; }
    [Column("tags")][MaxLength(4000)] public string? Tags { get; set; }
    [Column("brand")][MaxLength(4000)] public string? Brand { get; set; }
    [Column("sku")][MaxLength(4000)] public string? Sku { get; set; }
    [Column("weight")] public long? Weight { get; set; }
    [Column("dimensions.width")] public double? DimensionsWidth { get; set; }
    [Column("dimensions.height")] public double? DimensionsHeight { get; set; }
    [Column("dimensions.depth")] public double? DimensionsDepth { get; set; }
    [Column("warrantyInformation")][MaxLength(4000)] public string? WarrantyInformation { get; set; }
    [Column("shippingInformation")][MaxLength(4000)] public string? ShippingInformation { get; set; }
    [Column("availabilityStatus")][MaxLength(4000)] public string? AvailabilityStatus { get; set; }
    [Column("reviews")][MaxLength(4000)] public string? Reviews { get; set; }
    [Column("returnPolicy")][MaxLength(4000)] public string? ReturnPolicy { get; set; }
    [Column("minimumOrderQuantity")] public long? MinimumOrderQuantity { get; set; }
    [Column("meta.createdAt")] public DateTimeOffset? MetaCreatedAt { get; set; }
    [Column("meta.updatedAt")] public DateTimeOffset? MetaUpdatedAt { get; set; }
    [Column("meta.barcode")][MaxLength(4000)] public string? MetaBarcode { get; set; }
    [Column("meta.qrCode")] public Uri? MetaQrCode { get; set; }
    [Column("images")][MaxLength(4000)] public string? Images { get; set; }
    [Column("thumbnail")] public Uri? Thumbnail { get; set; }
}