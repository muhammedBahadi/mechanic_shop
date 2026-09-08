namespace MechanicShop.Domain.Common.Results;

public readonly record struct Error
{
    private Error(string code,string description, ErrorKind kind)
    {
        Code = code;
        Description = description;
        Kind = kind;
    }
    
    public string Code { get; }
    public string Description { get; }
    public ErrorKind Kind { get; }


    public static Error Failure(string code = nameof(Failure), string description = "An error occurred.") 
        => new(code, description, ErrorKind.failure);
    public static Error Unexpected(string code = nameof(Unexpected), string description = "An unexpected error occurred.") 
        => new(code, description, ErrorKind.Unexpected);
    public static Error Validation(string code = nameof(Validation), string description = "Validation failed.") 
        => new(code, description, ErrorKind.Validation);
    public static Error Conflict(string code = nameof(Conflict), string description = "A conflict occurred.") 
        => new(code, description, ErrorKind.Conflict);
    public static Error NotFound(string code = nameof(NotFound), string description = "The requested resource was not found.") 
        => new(code, description, ErrorKind.NotFound);
    public static Error Unauthorized(string code = nameof(Unauthorized), string description = "The request is not authorized.") 
        => new(code, description, ErrorKind.Unauthorized);
    public static Error Forbidden(string code = nameof(Forbidden), string description = "The request is forbidden.") 
        => new(code, description, ErrorKind.Forbidden);
}