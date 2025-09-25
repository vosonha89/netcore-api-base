using System.ComponentModel.DataAnnotations;

namespace Top.MasonTech.NetCoreBaseAPI.Presentation.APIs.Product.Dtos;

public class UpdateProductDto
{
    [MaxLength(4000)] public string? Title { get; init; }

    [MaxLength(4000)] public string? Description { get; init; }

    [MaxLength(4000)] public string? Category { get; init; }

    public double? Price { get; init; }

    public double? DiscountPercentage { get; init; }

    public double? Rating { get; init; }

    public long? Stock { get; init; }

    [MaxLength(4000)] public string? Tags { get; init; }

    [MaxLength(4000)] public string? Brand { get; init; }

    [MaxLength(4000)] public string? Sku { get; init; }

    public long? Weight { get; init; }

    public double? DimensionsWidth { get; init; }

    public double? DimensionsHeight { get; init; }

    public double? DimensionsDepth { get; init; }

    [MaxLength(4000)] public string? WarrantyInformation { get; init; }

    [MaxLength(4000)] public string? ShippingInformation { get; init; }

    [MaxLength(4000)] public string? AvailabilityStatus { get; init; }

    [MaxLength(4000)] public string? Reviews { get; init; }

    [MaxLength(4000)] public string? ReturnPolicy { get; init; }

    public long? MinimumOrderQuantity { get; init; }

    public DateTimeOffset? MetaCreatedAt { get; init; }

    public DateTimeOffset? MetaUpdatedAt { get; init; }

    [MaxLength(4000)] public string? MetaBarcode { get; init; }

    public Uri? MetaQrCode { get; init; }

    [MaxLength(4000)] public string? Images { get; init; }

    public Uri? Thumbnail { get; init; }
}