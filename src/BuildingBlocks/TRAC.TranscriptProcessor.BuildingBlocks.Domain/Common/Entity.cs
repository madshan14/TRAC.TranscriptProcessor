using TRAC.TranscriptProcessor.BuildingBlocks.Domain.Events;

namespace TRAC.TranscriptProcessor.BuildingBlocks.Domain.Common;

/// <summary>
/// Base class for all domain entities.
/// </summary>
public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = [];

    protected Entity()
    {
    }

    protected Entity(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; protected set; }

    public IReadOnlyCollection<IDomainEvent> DomainEvents =>
        _domainEvents.AsReadOnly();

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}