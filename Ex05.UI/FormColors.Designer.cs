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

        //private const int k_InitialXLoc = 15;
        //private const int k_InitialYLoc = 15;
        //private const int k_ButtonWidth = 40;
        //private const int k_ButtonHeight = 40;
        //private const int k_ButtonHorizontalGap = 15;
        //private const int k_BottonVerticalGap = 15;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            buttonColors1 = new ButtonColors();
            buttonColors2 = new ButtonColors();
            buttonColors3 = new ButtonColors();
            buttonColors4 = new ButtonColors();
            buttonColors5 = new ButtonColors();
            buttonColors6 = new ButtonColors();
            buttonColors7 = new ButtonColors();
            buttonColors8 = new ButtonColors();
            SuspendLayout();
            // 
            // buttonColors1
            // 
            buttonColors1.BackColor = Color.Blue;
            buttonColors1.Color = null;
            buttonColors1.Location = new Point(32, 216);
            buttonColors1.Name = "buttonColors1";
            buttonColors1.SelectedButton = null;
            buttonColors1.Size = new Size(150, 150);
            buttonColors1.TabIndex = 0;
            buttonColors1.UseVisualStyleBackColor = false;
            // 
            // buttonColors2
            // 
            buttonColors2.BackColor = Color.Purple;
            buttonColors2.Color = null;
            buttonColors2.Location = new Point(32, 32);
            buttonColors2.Name = "buttonColors2";
            buttonColors2.SelectedButton = null;
            buttonColors2.Size = new Size(150, 150);
            buttonColors2.TabIndex = 0;
            buttonColors2.UseVisualStyleBackColor = false;
            // 
            // buttonColors3
            // 
            buttonColors3.BackColor = Color.Red;
            buttonColors3.Color = null;
            buttonColors3.Location = new Point(228, 32);
            buttonColors3.Name = "buttonColors3";
            buttonColors3.SelectedButton = null;
            buttonColors3.Size = new Size(150, 150);
            buttonColors3.TabIndex = 0;
            buttonColors3.UseVisualStyleBackColor = false;
            // 
            // buttonColors4
            // 
            buttonColors4.BackColor = Color.Yellow;
            buttonColors4.Color = null;
            buttonColors4.Location = new Point(228, 216);
            buttonColors4.Name = "buttonColors4";
            buttonColors4.SelectedButton = null;
            buttonColors4.Size = new Size(150, 150);
            buttonColors4.TabIndex = 0;
            buttonColors4.UseVisualStyleBackColor = false;
            // 
            // buttonColors5
            // 
            buttonColors5.BackColor = Color.Brown;
            buttonColors5.Color = null;
            buttonColors5.Location = new Point(434, 216);
            buttonColors5.Name = "buttonColors5";
            buttonColors5.SelectedButton = null;
            buttonColors5.Size = new Size(150, 150);
            buttonColors5.TabIndex = 0;
            buttonColors5.UseVisualStyleBackColor = false;
            // 
            // buttonColors6
            // 
            buttonColors6.BackColor = Color.Green;
            buttonColors6.Color = null;
            buttonColors6.Location = new Point(434, 32);
            buttonColors6.Name = "buttonColors6";
            buttonColors6.SelectedButton = null;
            buttonColors6.Size = new Size(150, 150);
            buttonColors6.TabIndex = 0;
            buttonColors6.UseVisualStyleBackColor = false;
            // 
            // buttonColors7
            // 
            buttonColors7.BackColor = Color.Cyan;
            buttonColors7.Color = null;
            buttonColors7.Location = new Point(631, 32);
            buttonColors7.Name = "buttonColors7";
            buttonColors7.SelectedButton = null;
            buttonColors7.Size = new Size(150, 150);
            buttonColors7.TabIndex = 0;
            buttonColors7.UseVisualStyleBackColor = false;
            // 
            // buttonColors8
            // 
            buttonColors8.BackColor = Color.White;
            buttonColors8.Color = null;
            buttonColors8.Location = new Point(631, 216);
            buttonColors8.Name = "buttonColors8";
            buttonColors8.SelectedButton = null;
            buttonColors8.Size = new Size(150, 150);
            buttonColors8.TabIndex = 0;
            buttonColors8.UseVisualStyleBackColor = false;
            // 
            // FormColors
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 390);
            Controls.Add(buttonColors8);
            Controls.Add(buttonColors7);
            Controls.Add(buttonColors6);
            Controls.Add(buttonColors5);
            Controls.Add(buttonColors4);
            Controls.Add(buttonColors3);
            Controls.Add(buttonColors2);
            Controls.Add(buttonColors1);
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

        private Color m_ColorResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ButtonColors buttonColors1;
        private ButtonColors buttonColors2;
        private ButtonColors buttonColors3;
        private ButtonColors buttonColors4;
        private ButtonColors buttonColors5;
        private ButtonColors buttonColors6;
        private ButtonColors buttonColors7;
        private ButtonColors buttonColors8;

        public Color ChosenColor { get { return m_ColorResult; } }

    }
}