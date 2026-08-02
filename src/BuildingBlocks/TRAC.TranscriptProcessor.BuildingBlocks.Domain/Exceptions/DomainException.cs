namespace TRAC.TranscriptProcessor.BuildingBlocks.Domain.Exceptions;

/// <summary>
/// Represents an exception caused by a violated business rule.
/// </summary>
public class DomainException : Exception
{
    public DomainException(string message)
        : base(message)
    {
    }

    public DomainException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}