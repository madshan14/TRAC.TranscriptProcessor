using System;
using System.Collections.Generic;
using System.Text;

namespace TRAC.TranscriptProcessor.BuildingBlocks.Domain.Events
{
    /// <summary>
    /// Represents a business event that occurred inside the domain.
    /// </summary>
    public interface IDomainEvent
    {
        DateTime OccurredOnUtc { get; }
    }
}
