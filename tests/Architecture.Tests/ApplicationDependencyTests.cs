using Xunit;

namespace Architecture.Tests;

public class ApplicationDependencyTests
{

    [Fact]
    public void Identity_Application_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .Application_Should_Not_Depend_On_Infrastructure(
                typeof(
                TRAC.TranscriptProcessor.Modules.Identity.Application.AssemblyReference)
                .Assembly);
    }


    [Fact]
    public void Images_Application_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .Application_Should_Not_Depend_On_Infrastructure(
                typeof(
                TRAC.TranscriptProcessor.Modules.Images.Application.AssemblyReference)
                .Assembly);
    }


    [Fact]
    public void Transcript_Application_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .Application_Should_Not_Depend_On_Infrastructure(
                typeof(
                TRAC.TranscriptProcessor.Modules.Transcript.Application.AssemblyReference)
                .Assembly);
    }


    [Fact]
    public void Processing_Application_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .Application_Should_Not_Depend_On_Infrastructure(
                typeof(
                TRAC.TranscriptProcessor.Modules.Processing.Application.AssemblyReference)
                .Assembly);
    }
}