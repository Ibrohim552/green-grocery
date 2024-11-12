using System.Runtime.InteropServices.JavaScript;
using FarmConnect.Application.Result;

namespace FarmConnect.Application.Responces;


public class ApiResponse<T>
{
    public bool IsSuccess { get; init; }
    public JSType.Error Error { get; init; }
    public T? Data { get; init; }

    private ApiResponse(bool isSuccess, JSType.Error error, T? data)
    {
        IsSuccess = isSuccess;
        Error = error;
        Data = data;
    }

    public ApiResponse<T> Success(T? data) => new(true, Error.None(), data);

    public static ApiResponse<T> Fail(Error error) => new(false, error, default);
}