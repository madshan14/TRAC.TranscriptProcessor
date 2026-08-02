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
}