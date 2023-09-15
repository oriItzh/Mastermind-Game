namespace Ex05.UI
{
    public partial class FormGame : Form
    {

        public struct BingoCount
        {
            public int Bool { get; set; }
            public int Pgia { get; set; }
        }

        BingoCount CheckGuess(List<Color> guess)
        {
            if (guess.Count != r_GamePin.Length)
            {
                throw new ArgumentException("Must enter all 4 fields");
            }

            var scoreCount = new BingoCount
            {
                Bool = 0,
                Pgia = 0
            };

            for (int i = 0; i < guess.Count; ++i)
            {
                if (guess[i] == r_GamePin[i])
                {
                    scoreCount.Bool++;
                }
                else if (guess.Contains(guess[i]))
                {
                    scoreCount.Pgia++;
                }
            }

            return scoreCount;
        }

        private const int k_PinLength = 4;
        private Color[] r_GamePin;
        private int m_CurrentRound;

        public FormGame(int numberOfGuesses)
        {
            r_FormStart = new FormStart();
            gameLinePanels = new List<GameLinePanel>();
            int numberOfColors = FormColors.sr_optionalColors.Length;
            CreateNewPin(numberOfColors);
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
                gameLineControl.Name = String.Format("gameLineControl{0}", i + 1);
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
                //ComputeResult(CurrentTurn.TurnGuess);
                m_CurrentRound++;
                if (m_CurrentRound < gameLinePanels.Count)
                {
                    gameLinePanels[m_CurrentRound].EnableAllButtons();
                }
                else
                {
                    //GameOver
                }
            }
        }

        private void CreateNewPin(int numberOfColors)
        {
            r_GamePin = new Color[k_PinLength];
            var rnd = new Random();
            var randomNumbers = Enumerable.Range(0, numberOfColors).OrderBy(x => rnd.Next()).Take(k_PinLength).ToList();
            for (int i = 0; i < k_PinLength; ++i)
            {
                r_GamePin[i] = FormColors.sr_optionalColors[randomNumbers[i]];
            }
        }

        private BingoCount OnSubmitClicked(List<Color> colors)
        {
            ++m_CurrentRound;
            return CheckGuess(colors);
        }
    }
}