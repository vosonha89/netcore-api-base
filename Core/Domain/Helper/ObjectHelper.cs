namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Helper;

/// <summary>
/// Object helper class
/// </summary>
public static class ObjectHelper
{
    /// <summary>
    /// Mapping data using deep copy property
    /// </summary>
    /// <param name="source">Source object to copy from</param>
    /// <param name="dest">Destination object to copy to</param>
    /// <returns>The modified destination object</returns>
    public static TDest Map<TDest, TSource>(TSource source, TDest dest) where TDest : class, new()
    {
        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }
        else
        {
            var properties = dest.GetType().GetProperties();
            foreach (var property in properties)
            {
                try
                {
                    var sourceValue = source.GetType().GetProperty(property.Name)?.GetValue(source);
                    if (sourceValue is not null)
                    {
                        // Perform deep copy using JSON serialization
                        var serialized = System.Text.Json.JsonSerializer.Serialize(sourceValue);
                        var deserialized =
                            System.Text.Json.JsonSerializer.Deserialize(serialized, property.PropertyType);
                        property.SetValue(dest, deserialized);
                    }
                }
                catch
                {
                    Console.WriteLine($"Property {property.Name} can't be copied");
                }
            }
        }

        return dest;
    }
}