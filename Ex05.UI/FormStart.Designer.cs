namespace Ex05.UI
{
    partial class FormStart
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            m_ButtonChancesCounter = new Button();
            m_ButtonStart = new Button();
            SuspendLayout();
            // 
            // m_ButtonChancesCounter
            // 
            m_ButtonChancesCounter.Location = new Point(28, 67);
            m_ButtonChancesCounter.Name = "m_ButtonChancesCounter";
            m_ButtonChancesCounter.Size = new Size(734, 110);
            m_ButtonChancesCounter.TabIndex = 0;
            m_ButtonChancesCounter.Text = "Number of chances:";
            m_ButtonChancesCounter.UseVisualStyleBackColor = true;
            // 
            // m_ButtonStart
            // 
            m_ButtonStart.Location = new Point(503, 235);
            m_ButtonStart.Name = "m_ButtonStart";
            m_ButtonStart.Size = new Size(259, 79);
            m_ButtonStart.TabIndex = 1;
            m_ButtonStart.Text = "start";
            m_ButtonStart.UseVisualStyleBackColor = true;
            // 
            // FormStart
            // 
            AcceptButton = m_ButtonStart;
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 353);
            Controls.Add(m_ButtonStart);
            Controls.Add(m_ButtonChancesCounter);
            Cursor = Cursors.Arrow;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStart";
            Text = "Bool Pgia";
            Load += FormStart_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button m_ButtonChancesCounter;
        private Button m_ButtonStart;
        private int m_NumOfChances = 4;


    }
}