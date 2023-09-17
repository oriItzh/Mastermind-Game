namespace Ex05.UI
{
    partial class GameLinePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonSubmit = new Button();
            buttonColors1 = new ButtonColors();
            buttonColors2 = new ButtonColors();
            buttonColors3 = new ButtonColors();
            buttonColors4 = new ButtonColors();
            scorePanel1 = new ScorePanel();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(663, 63);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(146, 61);
            buttonSubmit.TabIndex = 1;
            buttonSubmit.Text = "-->>";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += ButtonSubmit_Click;
            // 
            // buttonColors1
            // 
            buttonColors1.Color = null;
            buttonColors1.Location = new Point(50, 33);
            buttonColors1.Name = "buttonColors1";
            buttonColors1.SelectedButton = null;
            buttonColors1.Size = new Size(120, 120);
            buttonColors1.TabIndex = 3;
            buttonColors1.UseVisualStyleBackColor = true;
            // 
            // buttonColors2
            // 
            buttonColors2.Color = null;
            buttonColors2.Location = new Point(200, 33);
            buttonColors2.Name = "buttonColors2";
            buttonColors2.SelectedButton = null;
            buttonColors2.Size = new Size(120, 120);
            buttonColors2.TabIndex = 4;
            buttonColors2.UseVisualStyleBackColor = true;
            // 
            // buttonColors3
            // 
            buttonColors3.Color = null;
            buttonColors3.Location = new Point(350, 33);
            buttonColors3.Name = "buttonColors3";
            buttonColors3.SelectedButton = null;
            buttonColors3.Size = new Size(120, 120);
            buttonColors3.TabIndex = 3;
            buttonColors3.UseVisualStyleBackColor = true;
            // 
            // buttonColors4
            // 
            buttonColors4.Color = null;
            buttonColors4.Location = new Point(500, 33);
            buttonColors4.Name = "buttonColors4";
            buttonColors4.SelectedButton = null;
            buttonColors4.Size = new Size(120, 120);
            buttonColors4.TabIndex = 4;
            buttonColors4.UseVisualStyleBackColor = true;
            // 
            // scorePanel1
            // 
            scorePanel1.Location = new Point(829, 20);
            scorePanel1.Name = "scorePanel1";
            scorePanel1.Size = new Size(149, 146);
            scorePanel1.TabIndex = 5;
            // 
            // errorProvider1
            // 
            // 
            // GameLinePanel
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scorePanel1);
            Controls.Add(buttonColors1);
            Controls.Add(buttonColors2);
            Controls.Add(buttonColors3);
            Controls.Add(buttonColors4);
            Controls.Add(buttonSubmit);
            Name = "GameLinePanel";
            Size = new Size(997, 180);
            ResumeLayout(false);
        }

        #endregion

        //public delegate FormGame.ScoreBoard checkGuess(List<Color> guess);

        public event EventHandler Submitted;
        public const int k_ScoreBoxSize = 50;
        private readonly List<Color> r_TurnGuess;
        private readonly List<Color> r_correctGuess;
        private readonly FormColors r_FormColors;
        private ButtonColors buttonColors1;
        private ButtonColors buttonColors2;
        private ButtonColors buttonColors3;
        private ButtonColors buttonColors4;
        private Button buttonSubmit;
        private ScorePanel scorePanel1;

        public ScorePanel ScorePanel => scorePanel1;
    }
}
