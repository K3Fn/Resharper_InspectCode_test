using System.Collections.Generic;
using DI.MicrosoftExtensions.ServiceConfiguration;

namespace WindowsAppNet6
{
    internal class RootConfiguration : CompositeConfiguration
    {
        protected override IEnumerable<IServiceConfiguration> GetConfigurations()
        {
            yield return new DialogsConfiguration();
        }
    }
}
