using Xunit;

namespace Architecture.Tests;

public class BuildingBlocksDependencyTests
{
    [Fact]
    public void BuildingBlocks_Domain_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .BuildingBlocks_Domain_Should_Follow_Rules(
                typeof(
                    TRAC.TranscriptProcessor.BuildingBlocks.Domain
                        .AssemblyReference)
                    .Assembly);
    }


    [Fact]
    public void BuildingBlocks_Application_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .BuildingBlocks_Application_Should_Follow_Rules(
                typeof(
                    TRAC.TranscriptProcessor.BuildingBlocks.Application
                        .AssemblyReference)
                    .Assembly);
    }


    [Fact]
    public void BuildingBlocks_Infrastructure_Should_Follow_Rules()
    {
        ArchitectureTestBase
            .BuildingBlocks_Infrastructure_Should_Follow_Rules(
                typeof(
                    TRAC.TranscriptProcessor.BuildingBlocks.Infrastructure
                        .AssemblyReference)
                    .Assembly);
    }
}