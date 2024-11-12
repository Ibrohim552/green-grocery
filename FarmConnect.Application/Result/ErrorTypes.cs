namespace FarmConnect.Application.Result;

public enum ErrorTypes
{
    None,
    BadRequest,
    NotFound,
    AlreadyExist,
    Conflict,
    InternalServerError,
}