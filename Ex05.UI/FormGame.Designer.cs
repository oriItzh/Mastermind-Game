namespace Ex05.UI
{
    partial class FormGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private const int k_InitialXLocation = 20;
        private const int k_InitialYLocation = 100;
        private const int k_ControlHeight = 50;
        private const int k_ControlWidth = 400;
        private const int k_GapBetweenControls = 10;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // gamePin1
            // 
            m_GamePin.Location = new Point(67, 59);
            m_GamePin.Name = "gamePin1";
            m_GamePin.Size = new Size(746, 190);
            m_GamePin.TabIndex = 0;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 1388);
            Controls.Add(m_GamePin);
            Name = "FormGame";
            Text = "FormGame";
            ResumeLayout(false);
        }

        #endregion

        private const int k_PinLength = 4;

        private int m_CurrentRound;
        private readonly List<GameLinePanel> r_GameLinePanels;
        private GamePin m_GamePin;
    }
}