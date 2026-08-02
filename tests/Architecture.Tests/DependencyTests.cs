using Xunit;

namespace Architecture.Tests;

public class DependencyTests
{

    [Fact]
    public void Identity_Domain_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .Domain_Should_Not_Have_Invalid_Dependencies(
                typeof(
                TRAC.TranscriptProcessor.Modules.Identity.Domain.AssemblyReference)
                .Assembly);
    }


    [Fact]
    public void Images_Domain_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .Domain_Should_Not_Have_Invalid_Dependencies(
                typeof(
                TRAC.TranscriptProcessor.Modules.Images.Domain.AssemblyReference)
                .Assembly);
    }


    [Fact]
    public void Transcript_Domain_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .Domain_Should_Not_Have_Invalid_Dependencies(
                typeof(
                TRAC.TranscriptProcessor.Modules.Transcript.Domain.AssemblyReference)
                .Assembly);
    }


    [Fact]
    public void Processing_Domain_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .Domain_Should_Not_Have_Invalid_Dependencies(
                typeof(
                TRAC.TranscriptProcessor.Modules.Processing.Domain.AssemblyReference)
                .Assembly);
    }
}