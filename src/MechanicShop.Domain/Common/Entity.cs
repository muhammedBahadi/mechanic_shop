namespace MechanicShop.Domain.Common.Constants;

public abstract class Entity
{
    public Guid Id { get; set; } 

    protected Entity()
    {}

    protected Entity(Guid id)
    {
        Id = id == Guid.Empty ? Guid.NewGuid() : id;
    }
}