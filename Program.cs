//#define RUN_EXAMPLE_USAGE_CONSOLE

using dotATM.Services;

namespace dotATM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if RUN_EXAMPLE_USAGE_CONSOLE
            RunServiceExampleUsage();

#else
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.WelcomeForm());
#endif
        }

        static void RunServiceExampleUsage()
        {
            ExampleUsage.ExampleUsageMain();
        }
    }
}