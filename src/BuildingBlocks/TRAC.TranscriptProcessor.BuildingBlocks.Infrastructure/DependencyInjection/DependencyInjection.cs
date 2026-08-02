using Microsoft.Extensions.DependencyInjection;
using TRAC.TranscriptProcessor.BuildingBlocks.Application.Abstractions.Time;
using TRAC.TranscriptProcessor.BuildingBlocks.Infrastructure.Time;

namespace TRAC.TranscriptProcessor.BuildingBlocks.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddBuildingBlocksInfrastructure(
        this IServiceCollection services)
    {
        services.AddSingleton<IDateTimeProvider, SystemDateTimeProvider>();

        return services;
    }
}