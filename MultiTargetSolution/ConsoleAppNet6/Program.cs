using ClassLibrary1;
using DI.MicrosoftExtensions.ServiceConfiguration;

namespace ConsoleAppNet6
{
    internal static class Program
    {
        static void Main()
        {
            using var serviceProvider = ServiceProviderBuilder.Build<RootConfiguration>();

            var commonClass = new CommonClass(100);
            Console.WriteLine(commonClass.UsedByNet6());
        }

        public static void UnusedNet6()
        {

        }
    }
}