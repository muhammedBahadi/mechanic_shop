namespace MechanicShop.Domain.Common.Results;

public enum ErrorKind
{
    failure,
    Unexpected,
    Validation,
    Conflict,
    NotFound,
    Unauthorized,
    Forbidden,
}
