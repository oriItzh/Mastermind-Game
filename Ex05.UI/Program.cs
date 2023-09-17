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
            PlayNewGame();
        }

        private static void PlayNewGame()
        {
            bool wantsToPlay = true;
            while (wantsToPlay)
            {
                int numOfChances = GetNumOfChances();
                FormGame formGame = new FormGame(numOfChances);
                formGame.ShowDialog();
                wantsToPlay = formGame.DialogResult == DialogResult.Continue;
            }
        }

        private static int GetNumOfChances()
        {
            FormStart formStart = new FormStart();
            formStart.ShowDialog();
            return formStart.NumOfChances;
        }
    }
}