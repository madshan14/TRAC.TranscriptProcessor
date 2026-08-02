using Xunit;

namespace Architecture.Tests;

public class InfrastructureDependencyTests
{
    [Fact]
    public void Identity_Infrastructure_Should_Follow_Rules()
    {
        ArchitectureTestBase.Infrastructure_Should_Not_Depend_On_Presentation(
            typeof(
            TRAC.TranscriptProcessor.Modules.Identity.Infrastructure.AssemblyReference)
            .Assembly);
    }


    [Fact]
    public void Images_Infrastructure_Should_Follow_Rules()
    {
        ArchitectureTestBase.Infrastructure_Should_Not_Depend_On_Presentation(
            typeof(
            TRAC.TranscriptProcessor.Modules.Images.Infrastructure.AssemblyReference)
            .Assembly);
    }


    [Fact]
    public void Transcript_Infrastructure_Should_Follow_Rules()
    {
        ArchitectureTestBase.Infrastructure_Should_Not_Depend_On_Presentation(
            typeof(
            TRAC.TranscriptProcessor.Modules.Transcript.Infrastructure.AssemblyReference)
            .Assembly);
    }


    [Fact]
    public void Processing_Infrastructure_Should_Follow_Rules()
    {
        ArchitectureTestBase.Infrastructure_Should_Not_Depend_On_Presentation(
            typeof(
            TRAC.TranscriptProcessor.Modules.Processing.Infrastructure.AssemblyReference)
            .Assembly);
    }
}