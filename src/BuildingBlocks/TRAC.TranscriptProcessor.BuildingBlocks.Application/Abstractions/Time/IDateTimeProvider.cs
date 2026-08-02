namespace TRAC.TranscriptProcessor.BuildingBlocks.Application.Abstractions.Time;

/// <summary>
/// Provides the current UTC date and time.
/// </summary>
public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}