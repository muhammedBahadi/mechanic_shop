namespace MechanicShop.Application.Features.Labors.Queries.GetLabors;

public sealed record GetLaborsQuery() : ICachedQuery<Result<List<LaborDto>>>
{
    public string CacheKey => $"labors";
    public string[] Tags => ["labors"];

    public TimeSpan Expiration => TimeSpan.FromMinutes(10);
}