using Microsoft.Extensions.DependencyInjection;

namespace TRAC.TranscriptProcessor.BuildingBlocks.Application.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddBuildingBlocksApplication(
        this IServiceCollection services)
    {
        return services;
    }
}