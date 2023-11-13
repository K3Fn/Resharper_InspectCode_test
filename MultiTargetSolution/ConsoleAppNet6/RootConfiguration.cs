using DI.MicrosoftExtensions.ServiceConfiguration;

namespace ConsoleAppNet6
{
    internal class RootConfiguration : CompositeConfiguration
    {
        protected override IEnumerable<IServiceConfiguration> GetConfigurations()
        {
            yield return new DialogsConfiguration();
        }
    }
}
