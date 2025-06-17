using System.Text;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Helper;

/// <summary>
/// Provides utility functions for common operations
/// </summary>
public static class FunctionHelper
{
    /// <summary>
    /// Converts a string to its Base64 representation
    /// </summary>
    /// <param name="plainText">The string to convert</param>
    /// <returns>Base64 encoded string</returns>
    public static string StringToBase64(string plainText)
    {
        if (string.IsNullOrEmpty(plainText))
        {
            return string.Empty;
        }

        var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        return Convert.ToBase64String(plainTextBytes);
    }
}