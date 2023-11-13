using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace DI.MicrosoftExtensions.ServiceConfiguration;

public abstract class CompositeConfiguration : IServiceConfiguration
{
    public void Configure(IServiceCollection services)
    {
        foreach (var configuration in GetConfigurations())
            configuration.Configure(services);
    }

    protected abstract IEnumerable<IServiceConfiguration> GetConfigurations();
}