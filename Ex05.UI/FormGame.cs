namespace Ex05.UI
{
    public partial class FormGame : Form
    {
        public const string k_GameOverMessage = "No more guesses allowed! you Lost";

        public void CheckGuess(GameLinePanel i_GameLine)
        {
            List<Color> currentGuess = new List<Color>();

            foreach (var control in i_GameLine.Controls)
            {
                if (control is ButtonColors buttonColors
                    && buttonColors.Color != null)
                {
                    currentGuess.Add((Color)buttonColors.Color);
                }
            }

            if (currentGuess.Count < k_PinLength)
            {
                throw new ArgumentException("Must enter all 4 fields");
            }

            for (int i = 0; i < currentGuess.Count; i++)
            {
                if (currentGuess[i] == m_GamePin.Pin[i])
                {
                    i_GameLine.ScorePanel.ScoreCounter.Bull++;
                }
                else if (m_GamePin.Pin.Contains(currentGuess[i]))
                {
                    i_GameLine.ScorePanel.ScoreCounter.Cow++;
                }
            }
        }

        public FormGame(int i_NumberOfGuesses)
        {
            r_GameLinePanels = new List<GameLinePanel>();
            m_GamePin = new GamePin();
            int numberOfColors = FormColors.sr_optionalColors.Length;
            SetGamePin(numberOfColors);
            m_CurrentRound = 0;
            InitializeComponent();
            SuspendLayout();
            CreateGameLines(i_NumberOfGuesses);
            ResumeLayout(false);
            m_GamePin.Display();
        }

        private void CreateGameLines(int numberOfGuesses)
        {
            int xLoc = k_InitialXLocation;
            int yLoc = k_InitialYLocation;

            for (int i = 0; i < numberOfGuesses; ++i)
            {
                var gameLineControl = new GameLinePanel();
                gameLineControl.Location = new Point(xLoc, yLoc);
                gameLineControl.Name = string.Format("gameLineControl{0}", i + 1);
                gameLineControl.Size = new Size(k_ControlWidth, k_ControlHeight);
                gameLineControl.TabIndex = i;
                gameLineControl.Submitted += GameLine_Submitted;
                r_GameLinePanels.Add(gameLineControl);

                if (i > 0)
                {
                    gameLineControl.DisableAllButtons();
                }
                Controls.Add(gameLineControl);
                yLoc += k_ControlHeight + k_GapBetweenControls;
            }
        }

        private void GameLine_Submitted(object? sender, EventArgs e)
        {
            GameLinePanel CurrentTurn = sender as GameLinePanel;

            if (CurrentTurn != null)
            {
                try
                {
                    CheckGuess(CurrentTurn);
                    CurrentTurn.ScorePanel.DisplayResult();
                    m_CurrentRound++;
                    if (CurrentTurn.IsAWin())
                    {
                        DoWhenWonTheGame();
                    }
                    else
                    {
                        if (!IsGameOver())
                        {
                            r_GameLinePanels[m_CurrentRound].EnableAllButtons();
                        }
                        else
                        {
                            DoWhenGameOver();
                        }
                    }
                }
                catch (Exception ex)
                {
                    new FormError(ex.Message).ShowDialog();
                }
            }
        }

        private void DoWhenGameOver()
        {
            DoWhenGameEnds(k_GameOverMessage);
        }

        private void DoWhenGameEnds(string i_Message)
        {
            m_GamePin.Display();
            FormNewGame formNewGame = new FormNewGame(i_Message);

            if (formNewGame.ShowDialog() == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Continue;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void DoWhenWonTheGame()
        {
            string message = string.Format(
                "Congratulations! you have cracked the code after {0} guesses", m_CurrentRound);
            DoWhenGameEnds(message);
        }

        private void SetGamePin(int numberOfColors)
        {
            var random = new Random();
            var randomNumbers = Enumerable.Range(0, numberOfColors).OrderBy(x => random.Next()).Take(k_PinLength).ToList();
            for (int i = 0; i < k_PinLength; ++i)
            {
                Color colorToAdd = (Color)FormColors.sr_optionalColors[randomNumbers[i]];
                m_GamePin.Pin.Add(colorToAdd);

            }
        }

        private bool IsGameOver()
        {
            return m_CurrentRound >= r_GameLinePanels.Count;
        }
    }
}