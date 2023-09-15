namespace Ex05.UI
{
    partial class FormColors
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

        private const int NUMBER_OF_COLORS_IN_ROW = 4;
        private const int NUMBER_OF_COLORS_IN_COLUMN = 2;
        private const int INITIAL_X_LOC = 15;
        private const int INITIAL_Y_LOC = 15;
        private const int BUTTON_WIDTH = 40;
        private const int BUTTON_HEIGHT= 40;
        private const int BUTTON_HORIZONTAL_GAP = INITIAL_X_LOC;
        private const int BUTTON_VERTICAL_GAP = INITIAL_Y_LOC;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();

            // 
            // FormColors
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 500);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormColors";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PICK A COLOR";
            ResumeLayout(false);
        }

        #endregion

        public static readonly Color[] sr_optionalColors =
        {
            Color.Purple,
            Color.Red,
            Color.Green,
            Color.Cyan,
            Color.LightPink,
            Color.Brown,
            Color.Yellow,
            Color.Blue,
        };

        private List<ButtonColors> buttonColors;
        private Color m_ColorResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;

        public Color ChosenColor { get { return m_ColorResult; } }

    }
}