namespace MechanicShop.Application.Features.Identity.Queries.GetUserInfo;

public sealed record GetUserByIdQuery(string? UserId) : IRequest<Result<AppUserDto>>;