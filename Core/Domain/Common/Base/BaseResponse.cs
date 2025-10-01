using System.Net;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

/// <summary>
/// Base response data class for all API responses
/// </summary>
/// <typeparam name="T">Type of data being returned</typeparam>
public class BaseResponse<T>
{
    /// <summary>
    /// Server date and time when the response was generated
    /// </summary>
    public DateTime ServerDateTime { get; set; }

    /// <summary>
    /// HTTP status code
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// Response message
    /// </summary>
    public string Msg { get; set; }

    /// <summary>
    /// Exception details if an error occurred
    /// </summary>
    public ClientError? Exception { get; set; }

    /// <summary>
    /// Response data
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// Whether the request was successful
    /// </summary>
    public bool Successful { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public BaseResponse()
    {
        ServerDateTime = DateTime.UtcNow;
        Status = (int)HttpStatusCode.BadRequest;
        Msg = string.Empty;
        Exception = null;
        Data = default;
        Successful = false;
    }
}