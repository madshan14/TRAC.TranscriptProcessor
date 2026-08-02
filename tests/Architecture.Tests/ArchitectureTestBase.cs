using NetArchTest.Rules;
using Xunit;

namespace Architecture.Tests;

public static class ArchitectureTestBase
{
    public static void Domain_Should_Not_Have_Invalid_Dependencies(
        System.Reflection.Assembly assembly)
    {
        var result = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAny(
                "Application",
                "Infrastructure",
                "Presentation")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }


    public static void Application_Should_Not_Depend_On_Infrastructure(
        System.Reflection.Assembly assembly)
    {
        var result = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAny(
                "Infrastructure",
                "Presentation")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }


    public static void Infrastructure_Should_Not_Depend_On_Presentation(
        System.Reflection.Assembly assembly)
    {
        var result = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOn("Presentation")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }


    public static void Presentation_Should_Not_Depend_On_Infrastructure(
        System.Reflection.Assembly assembly)
    {
        var result = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOn("Infrastructure")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }


    public static void BuildingBlocks_Should_Not_Depend_On_Modules(
        System.Reflection.Assembly assembly)
    {
        var result = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOn(
                "TRAC.TranscriptProcessor.Modules")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }


    public static void BuildingBlocks_Domain_Should_Follow_Rules(
        System.Reflection.Assembly assembly)
    {
        Domain_Should_Not_Have_Invalid_Dependencies(assembly);
        BuildingBlocks_Should_Not_Depend_On_Modules(assembly);
    }


    public static void BuildingBlocks_Application_Should_Follow_Rules(
        System.Reflection.Assembly assembly)
    {
        Application_Should_Not_Depend_On_Infrastructure(assembly);
        BuildingBlocks_Should_Not_Depend_On_Modules(assembly);
    }


    public static void BuildingBlocks_Infrastructure_Should_Follow_Rules(
        System.Reflection.Assembly assembly)
    {
        Infrastructure_Should_Not_Depend_On_Presentation(assembly);
        BuildingBlocks_Should_Not_Depend_On_Modules(assembly);
    }
}