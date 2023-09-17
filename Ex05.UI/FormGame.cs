namespace Ex05.UI
{
    public partial class FormGame : Form
    {
        public void CheckGuess(GameLinePanel i_GameLine)
        {
            List<Color> currentGuess = new List<Color>();

            foreach (var VARIABLE in i_GameLine.Controls)
            {
                if (VARIABLE is ButtonColors buttonColors
                    && buttonColors.Color != null)
                {
                    currentGuess.Add((Color)buttonColors.Color);
                }
            }

            if (currentGuess.Count < k_PinLength)
            {
                throw new ArgumentException("Must enter all 4 fields");
            }

            for (int i = 0; i < currentGuess.Count; ++i)
            {
                if (currentGuess[i] == m_GamePin.Pin[i])
                {
                    i_GameLine.ScorePanel.BoolPgia.Bool++;
                }
                else if (currentGuess.Contains(currentGuess[i]))
                {
                    i_GameLine.ScorePanel.BoolPgia.Pgia++;
                }
            }
        }

        //BingoCount CheckGuess(List<Color> guess)
        //{
        //    if (guess.Count != m_GamePin.Pin.Count)
        //    {
        //        throw new ArgumentException("Must enter all 4 fields");
        //    }

        //    var scoreCount = new BingoCount
        //    {
        //        Bool = 0,
        //        Pgia = 0
        //    };

        //    for (int i = 0; i < guess.Count; ++i)
        //    {
        //        if (guess[i] == m_GamePin.Pin[i])
        //        {
        //            scoreCount.Bool++;
        //        }
        //        else if (guess.Contains(guess[i]))
        //        {
        //            scoreCount.Pgia++;
        //        }
        //    }

        //    return scoreCount;
        //}

        public FormGame(int numberOfGuesses)
        {
            gameLinePanels = new List<GameLinePanel>();
            m_GamePin = new GamePin();
            int numberOfColors = FormColors.sr_optionalColors.Length;
            SetGamePin(numberOfColors);
            m_CurrentRound = 0;
            InitializeComponent();
            SuspendLayout();
            CreateGameLines(numberOfGuesses);
            ResumeLayout(false);
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
                gameLinePanels.Add(gameLineControl);

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

                    m_CurrentRound++;
                    if (m_CurrentRound < gameLinePanels.Count)
                    {
                        gameLinePanels[m_CurrentRound].EnableAllButtons();
                    }
                    else
                    {
                        //GameOver - To be implemented
                    }
                }
                catch (Exception ex)
                {
                    //new FormError(ex.Message).ShowDialog(); To be Implemented
                }
            }
            m_GamePin.Display();    // Debugging purpose
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
    }
}