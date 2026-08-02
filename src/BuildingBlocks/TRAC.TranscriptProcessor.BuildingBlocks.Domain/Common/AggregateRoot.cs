namespace TRAC.TranscriptProcessor.BuildingBlocks.Domain.Common;

/// <summary>
/// Represents the root of an aggregate.
/// </summary>
public abstract class AggregateRoot : Entity
{
    protected AggregateRoot()
    {
    }

    protected AggregateRoot(Guid id)
        : base(id)
    {
    }
}