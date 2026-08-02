using TRAC.TranscriptProcessor.BuildingBlocks.Application.Abstractions.Time;

namespace TRAC.TranscriptProcessor.BuildingBlocks.Infrastructure.Time;

/// <summary>
/// Production implementation of <see cref="IDateTimeProvider"/>.
/// </summary>
public sealed class SystemDateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}