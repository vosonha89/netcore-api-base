using System.Net;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Constant;

namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Object;

/// <summary>
/// Error response class for API error responses
/// </summary>
public class ErrorDataResponse : BaseDataResponse<object?>
{
    /// <summary>
    /// Not found error
    /// </summary>
    public static ErrorDataResponse NotFound
    {
        get;
    } = new ErrorDataResponse(
        HttpStatusCode.NotFound,
        "The requested resource could not be found.",
        new ClientError
        {
            ErrorCode = GlobalError.NotFoundError.Code.ToString(), ErrorMessage = GlobalError.NotFoundError.Msg
        }
    );

    /// <summary>
    /// Unauthorized error
    /// </summary>
    public static ErrorDataResponse Unauthorized
    {
        get;
    } = new ErrorDataResponse(
        HttpStatusCode.Unauthorized,
        "The user does not have the necessary credentials.",
        new ClientError
        {
            ErrorCode = GlobalError.UnauthorizedError.Code.ToString(),
            ErrorMessage = GlobalError.UnauthorizedError.Msg
        }
    );

    /// <summary>
    /// Forbidden error
    /// </summary>
    public static ErrorDataResponse Forbidden
    {
        get;
    } = new ErrorDataResponse(
        HttpStatusCode.Forbidden,
        "The user might not have the necessary permissions for a resource.",
        new ClientError
        {
            ErrorCode = GlobalError.ForbiddenError.Code.ToString(), ErrorMessage = GlobalError.ForbiddenError.Msg
        }
    );

    /// <summary>
    /// Creates a new ErrorDataResponse instance
    /// </summary>
    /// <param name="status">The HTTP status code of the error</param>
    /// <param name="msg">Optional message describing the error</param>
    /// <param name="exception">Optional client error object containing additional error details</param>
    public ErrorDataResponse(HttpStatusCode status, string msg = "", ClientError? exception = null)
        : base(status, string.Empty, true, msg, exception)
    {
        Data = null;
        Status = (int)status;
        Successful = false;

        if (!string.IsNullOrEmpty(msg))
        {
            Msg = msg;
        }

        if (exception is not null)
        {
            Exception = exception;
        }
    }

    /// <summary>
    /// Creates a BadRequest error response
    /// </summary>
    /// <param name="exception">Optional client error details</param>
    /// <returns>A BadRequest error response</returns>
    public static ErrorDataResponse BadRequest(ClientError? exception = null)
    {
        return new ErrorDataResponse(
            HttpStatusCode.BadRequest,
            "The server cannot or will not process the request due to an apparent client error",
            exception
        );
    }

    /// <summary>
    /// Creates an InternalServerError response
    /// </summary>
    /// <param name="exception">Optional client error details</param>
    /// <returns>An InternalServerError response</returns>
    public static ErrorDataResponse InternalServerError(ClientError? exception = null)
    {
        return new ErrorDataResponse(
            HttpStatusCode.InternalServerError,
            "An unexpected condition was encountered and no more specific message is suitable",
            exception
        );
    }
}
