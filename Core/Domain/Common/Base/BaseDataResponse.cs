using System.Net;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

/// <summary>
/// Concrete implementation of BaseDataResponse for standard API responses
/// </summary>
/// <typeparam name="T">Type of data being returned</typeparam>
public class BaseDataResponse<T> : BaseResponse<T>
{
    /// <summary>
    /// Creates a new response with the specified parameters
    /// </summary>
    /// <param name="status">HTTP status code</param>
    /// <param name="data">Response data</param>
    /// <param name="successful">Whether the request was successful</param>
    /// <param name="msg">Response message</param>
    /// <param name="exception">Exception details if an error occurred</param>
    public BaseDataResponse(HttpStatusCode status, T? data = default, bool successful = false, string msg = "", ClientError? exception = null)
    {
        Status = (int)status;
        Msg = msg;
        Exception = exception;
        Data = data;
        Successful = successful;
    }
}