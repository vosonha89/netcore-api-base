using System.ComponentModel.DataAnnotations.Schema;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Base;

namespace Top.MasonTech.NetCoreBaseAPI.Infrastructure.Persistence.Entities;

/// <summary>
/// Product entity
/// </summary>
[Table("product")]
public class Product : BaseEntity<long>
{
    [Column("title")] public string? Title { get; set; }
    [Column("description")] public string? Description { get; set; }
    [Column("category")] public string? Category { get; set; }
    [Column("price")] public double? Price { get; set; }
    [Column("discountPercentage")] public double? DiscountPercentage { get; set; }
    [Column("rating")] public double? Rating { get; set; }
    [Column("stock")] public long? Stock { get; set; }
    [Column("tags")] public string? Tags { get; set; }
    [Column("brand")] public string? Brand { get; set; }
    [Column("sku")] public string? Sku { get; set; }
    [Column("weight")] public long? Weight { get; set; }
    [Column("dimensions.width")] public double? DimensionsWidth { get; set; }
    [Column("dimensions.height")] public double? DimensionsHeight { get; set; }
    [Column("dimensions.depth")] public double? DimensionsDepth { get; set; }
    [Column("warrantyInformation")] public string? WarrantyInformation { get; set; }
    [Column("shippingInformation")] public string? ShippingInformation { get; set; }
    [Column("availabilityStatus")] public string? AvailabilityStatus { get; set; }
    [Column("reviews")] public string? Reviews { get; set; }
    [Column("returnPolicy")] public string? ReturnPolicy { get; set; }
    [Column("minimumOrderQuantity")] public long? MinimumOrderQuantity { get; set; }
    [Column("meta.createdAt")] public DateTimeOffset? MetaCreatedAt { get; set; }
    [Column("meta.updatedAt")] public DateTimeOffset? MetaUpdatedAt { get; set; }
    [Column("meta.barcode")] public string? MetaBarcode { get; set; }
    [Column("meta.qrCode")] public Uri? MetaQrCode { get; set; }
    [Column("images")] public string? Images { get; set; }
    [Column("thumbnail")] public Uri? Thumbnail { get; set; }
}