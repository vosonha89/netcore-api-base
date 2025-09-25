using System.Net;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

/// <summary>
/// Base response data class for all API responses
/// </summary>
/// <typeparam name="T">Type of data being returned</typeparam>
public abstract class BaseResponseData<T>
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
    protected BaseResponseData()
    {
        ServerDateTime = DateTime.UtcNow;
        Status = (int)HttpStatusCode.BadRequest;
        Msg = string.Empty;
        Exception = null;
        Data = default;
        Successful = false;
    }
}



/// <summary>
/// Concrete implementation of BaseResponseData for standard API responses
/// </summary>
/// <typeparam name="T">Type of data being returned</typeparam>
public class BaseResponse<T> : BaseResponseData<T>
{
    /// <summary>
    /// Creates a new response with the specified parameters
    /// </summary>
    /// <param name="status">HTTP status code</param>
    /// <param name="data">Response data</param>
    /// <param name="successful">Whether the request was successful</param>
    /// <param name="msg">Response message</param>
    /// <param name="exception">Exception details if an error occurred</param>
    public BaseResponse(HttpStatusCode status, T? data = default, bool successful = false, string msg = "", ClientError? exception = null)
    {
        Status = (int)status;
        Msg = msg;
        Exception = exception;
        Data = data;
        Successful = successful;
    }

    /// <summary>
    /// Creates a successful OK response with the provided data
    /// </summary>
    /// <param name="data">Data to include in the response</param>
    /// <returns>A successful response with OK status</returns>
    public static BaseResponse<T> Ok(T? data = default)
    {
        return new BaseResponse<T>(HttpStatusCode.OK, data, true);
    }
}