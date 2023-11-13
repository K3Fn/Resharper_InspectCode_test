using Microsoft.Extensions.DependencyInjection;

namespace DI.MicrosoftExtensions.ServiceConfiguration;

public interface IServiceConfiguration
{
    void Configure(IServiceCollection services);
}