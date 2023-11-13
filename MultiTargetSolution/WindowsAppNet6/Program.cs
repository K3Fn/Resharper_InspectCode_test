using DI.MicrosoftExtensions.ServiceConfiguration;
using System;

namespace WindowsAppNet6
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            using var serviceProvider = ServiceProviderBuilder.Build<RootConfiguration>();

            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        public static void UnusedNet6Windows()
        {

        }
    }
}
