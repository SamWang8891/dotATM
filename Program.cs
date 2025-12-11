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

            // Create and show WelcomeForm, but don't make it the main form
            var welcomeForm = new Forms.WelcomeForm();
            welcomeForm.Show();

            // Run without specifying a main form
            Application.Run();
#endif
        }

        static void RunServiceExampleUsage()
        {
            ExampleUsage.ExampleUsageMain();
        }
    }
}