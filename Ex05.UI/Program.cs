namespace Ex05.UI
{
    public static class Program
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
            int numOfGuesses;

            while (wantsToPlay && TryGetNumOfGuesses(out numOfGuesses))
            {
                FormGame formGame = new FormGame(numOfGuesses);
                wantsToPlay = formGame.ShowDialog() == DialogResult.Continue;
            }
        }

        private static bool TryGetNumOfGuesses(out int i_NumOfGuesses)
        {
            FormStart formStart = new FormStart();
            i_NumOfGuesses = -1;

            if (formStart.ShowDialog() == DialogResult.OK)
            {
                i_NumOfGuesses = formStart.NumOfChances;
            }

            return i_NumOfGuesses > 0;
        }
    }
}