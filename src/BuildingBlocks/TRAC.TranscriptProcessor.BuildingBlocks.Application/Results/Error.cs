namespace TRAC.TranscriptProcessor.BuildingBlocks.Application.Results;

/// <summary>
/// Represents an application error.
/// </summary>
public sealed record Error(
    string Code,
    string Description)
{
    public static readonly Error None = new(string.Empty, string.Empty);
}