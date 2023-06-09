namespace Archway.SharedKernel.Core;

//DDD Abstract Aggregate class
public abstract class AggregateRoot : Entity
{
    protected AggregateRoot() : base() { }

    private readonly List<IDomainEvent> _domainEvents = new();
    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents;

    protected void RaiseDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);

    public void ClearDomainEvents() => _domainEvents.Clear();
}
