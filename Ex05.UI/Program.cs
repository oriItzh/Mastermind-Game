namespace Ex05.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FormGame());
            //new FormStart().ShowDialog();
            var fr = new FormStart();
            if (DialogResult.OK == fr.ShowDialog())
            {
                new FormGame(fr.NumOfChances).ShowDialog();
            }
        }
    }
}