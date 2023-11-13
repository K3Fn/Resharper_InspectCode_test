using System;
using Microsoft.Extensions.DependencyInjection;

namespace DI.MicrosoftExtensions.ServiceConfiguration;

public static class ServiceProviderBuilder
{
    public static ServiceProvider Build<TConfiguration>(Action<IServiceCollection>? initialConfigure = null, Action<IServiceCollection>? postConfigure = null, bool validate = true)
        where TConfiguration : IServiceConfiguration, new()
    {
        var services = BuildServiceCollection<TConfiguration>(initialConfigure, postConfigure);
        return BuildServiceProvider(services, validate);
    }

    private static IServiceCollection BuildServiceCollection<TConfiguration>(Action<IServiceCollection>? initialConfigure, Action<IServiceCollection>? postConfigure) 
        where TConfiguration : IServiceConfiguration, new()
    {
        var services = new ServiceCollection();
        
        initialConfigure?.Invoke(services);
        new TConfiguration().Configure(services);
        postConfigure?.Invoke(services);
        
        return services;
    }

    private static ServiceProvider BuildServiceProvider(IServiceCollection services, bool validate)
    {
        return services.BuildServiceProvider(CreateProviderOptions(validate));
    }
    
    private static ServiceProviderOptions CreateProviderOptions(bool validate) => new() { ValidateScopes = validate, ValidateOnBuild = validate };
}