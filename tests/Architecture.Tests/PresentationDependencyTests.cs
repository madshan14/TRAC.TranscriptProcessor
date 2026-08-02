using Xunit;

namespace Architecture.Tests;

public class PresentationDependencyTests
{
    [Fact]
    public void Identity_Presentation_Should_Follow_Rules()
    {
        ArchitectureTestBase.Presentation_Should_Not_Depend_On_Infrastructure(
            typeof(
            TRAC.TranscriptProcessor.Modules.Identity.Presentation.AssemblyReference)
            .Assembly);
    }


    [Fact]
    public void Images_Presentation_Should_Follow_Rules()
    {
        ArchitectureTestBase.Presentation_Should_Not_Depend_On_Infrastructure(
            typeof(
            TRAC.TranscriptProcessor.Modules.Images.Presentation.AssemblyReference)
            .Assembly);
    }


    [Fact]
    public void Transcript_Presentation_Should_Follow_Rules()
    {
        ArchitectureTestBase.Presentation_Should_Not_Depend_On_Infrastructure(
            typeof(
            TRAC.TranscriptProcessor.Modules.Transcript.Presentation.AssemblyReference)
            .Assembly);
    }


    [Fact]
    public void Processing_Presentation_Should_Follow_Rules()
    {
        ArchitectureTestBase.Presentation_Should_Not_Depend_On_Infrastructure(
            typeof(
            TRAC.TranscriptProcessor.Modules.Processing.Presentation.AssemblyReference)
            .Assembly);
    }
}