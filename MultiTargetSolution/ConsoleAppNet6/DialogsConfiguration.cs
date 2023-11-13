using Microsoft.Extensions.DependencyInjection;
using System.Text;
using DI.MicrosoftExtensions.ServiceConfiguration;

namespace ConsoleAppNet6
{
    internal class DialogsConfiguration : IServiceConfiguration
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<StringBuilder>();
        }
    }
}
